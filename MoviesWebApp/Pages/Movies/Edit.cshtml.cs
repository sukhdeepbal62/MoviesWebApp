﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoviesWebApp.BusinessLayer;
using MoviesWebApp.Data;

namespace MoviesWebApp.Pages.Movies
{
    public class EditModel : PageModel
    {
        private readonly MoviesWebApp.Data.MovieDBContext _context;

        public EditModel(MoviesWebApp.Data.MovieDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movies
                .Include(m => m.Category)
                .Include(m => m.Director)
                .Include(m => m.Platform).FirstOrDefaultAsync(m => m.Id == id);

            if (Movie == null)
            {
                return NotFound();
            }
           ViewData["CategoryID"] = new SelectList(_context.Categories, "Id", "CategoryName");
           ViewData["DirectorID"] = new SelectList(_context.Directors, "Id", "DirectorName");
           ViewData["PlatformID"] = new SelectList(_context.Platforms, "Id", "PlatformName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Movie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(Movie.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesWebApp.BusinessLayer;
using MoviesWebApp.Data;

namespace MoviesWebApp.Pages.Directors
{
    public class DeleteModel : PageModel
    {
        private readonly MoviesWebApp.Data.MovieDBContext _context;

        public DeleteModel(MoviesWebApp.Data.MovieDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Director Director { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Director = await _context.Directors.FirstOrDefaultAsync(m => m.Id == id);

            if (Director == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Director = await _context.Directors.FindAsync(id);

            if (Director != null)
            {
                _context.Directors.Remove(Director);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MoviesWebApp.BusinessLayer;
using MoviesWebApp.Data;

namespace MoviesWebApp.Pages.Directors
{
    public class CreateModel : PageModel
    {
        private readonly MoviesWebApp.Data.MovieDBContext _context;

        public CreateModel(MoviesWebApp.Data.MovieDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Director Director { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Directors.Add(Director);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

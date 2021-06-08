using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesWebApp.BusinessLayer;
using MoviesWebApp.Data;

namespace MoviesWebApp.Pages.Platforms
{
    public class DeleteModel : PageModel
    {
        private readonly MoviesWebApp.Data.MovieDBContext _context;

        public DeleteModel(MoviesWebApp.Data.MovieDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Platform Platform { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Platform = await _context.Platforms.FirstOrDefaultAsync(m => m.Id == id);

            if (Platform == null)
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

            Platform = await _context.Platforms.FindAsync(id);

            if (Platform != null)
            {
                _context.Platforms.Remove(Platform);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

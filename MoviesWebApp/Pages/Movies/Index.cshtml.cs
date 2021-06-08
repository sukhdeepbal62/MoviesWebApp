using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesWebApp.BusinessLayer;
using MoviesWebApp.Data;

namespace MoviesWebApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MoviesWebApp.Data.MovieDBContext _context;

        public IndexModel(MoviesWebApp.Data.MovieDBContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movies
                .Include(m => m.Category)
                .Include(m => m.Director)
                .Include(m => m.Platform).ToListAsync();
        }
    }
}

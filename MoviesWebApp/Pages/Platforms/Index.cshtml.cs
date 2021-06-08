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
    public class IndexModel : PageModel
    {
        private readonly MoviesWebApp.Data.MovieDBContext _context;

        public IndexModel(MoviesWebApp.Data.MovieDBContext context)
        {
            _context = context;
        }

        public IList<Platform> Platform { get;set; }

        public async Task OnGetAsync()
        {
            Platform = await _context.Platforms.ToListAsync();
        }
    }
}

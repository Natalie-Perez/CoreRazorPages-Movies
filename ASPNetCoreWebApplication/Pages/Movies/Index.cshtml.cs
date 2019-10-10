using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPNetCoreWebApplication.Models;
using RazorPagesMovie.Models;

namespace ASPNetCoreWebApplication.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly ASPNetCoreWebApplication.Models.RazorPagesMovieContext _context;

        public IndexModel(ASPNetCoreWebApplication.Models.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}

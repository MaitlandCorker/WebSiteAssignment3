using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using WebSiteAssignment2.Models;

namespace WebSiteAssignment2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Bands()
        {
            List<Band> model = _context.Bands.ToList();

            return View(model);
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Tour()
        {
            return View();
        }
        public IActionResult OneBand()
        {
            Band model = _context.Bands.FirstOrDefault();

            return View(model);
        }

        public IActionResult BandDetails(int id)
        {
            Band model = _context.Bands.Find(id);

            return View(model);
        }

        public IActionResult BandSearch(String SearchString, String GenreSearch)
        {
            if (!string.IsNullOrEmpty(SearchString))
            {
                var bands = from m in _context.Bands
                            where m.BandName.Contains(SearchString)
                            select m;
                List<Band> model = bands.ToList();
                ViewData["SearchString"] = SearchString;
                return View(model);
            }
            else
            if (!string.IsNullOrEmpty(GenreSearch))
            {
                var bands = from m in _context.Bands
                            where m.BandGenre.Contains(GenreSearch)
                            select m;
                List<Band> model = bands.ToList();
                ViewData["GenreSearch"] = GenreSearch;
                return View(model);
            }
            else
            {
                return View();
            }

            

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

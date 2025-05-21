using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcAWSSeriesPractica.Models;
using MvcAWSSeriesPractica.Repositories;

namespace MvcAWSSeriesPractica.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private RepositorySeries repo;

        public HomeController(RepositorySeries repo, ILogger<HomeController> logger)
        {
            this.repo = repo;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            List<Serie> series = await this.repo.GetSeriesAsync();
            return View(series);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using LB3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LB3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            DataViewModel dataViewModel = new DataViewModel();
            return View(dataViewModel);  
        }
        [HttpGet]
        public IActionResult Result(DataViewModel dataViewModel)
        {
            var resultViewModel = new ResultsViewModel(dataViewModel);

            return View(resultViewModel);
        }
        [HttpGet]
        public IActionResult Report(ResultsViewModel resultsViewModel)
        {
            return View(resultsViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
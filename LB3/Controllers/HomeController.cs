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
            DataViewModel dataViewModel = new DataViewModel
            {
                A1_ChZag = 65,
                A1_ChZag1 = 1,
                A1_ChZag2 = 1,
                A1_ChZag3 = 1,
                A1_ChZag4 = 0,
                A1_ChZag5 = 0,
                A1_ChZag6 = 1,
                A1_ChZagO = 4,

                A2_ChZag = 38,
                A2_ChZag1 = 0,
                A2_ChZag2 = 1,
                A2_ChZag3 = 0,
                A2_ChZag4 = 1,
                A2_ChZag5 = 1,
                A2_ChZag6 = 0,
                A2_ChZagO = 1,

                A3_ChZag = 21,
                A3_ChZag1 = 0,
                A3_ChZag2 = 0,
                A3_ChZag3 = 1,
                A3_ChZag4 = 0,
                A3_ChZag5 = 1,
                A3_ChZag6 = 2,
                A3_ChZagO = 2,

                A4_ChZag = 28,
                A4_ChZag1 = 1,
                A4_ChZag2 = 0,
                A4_ChZag3 = 0,
                A4_ChZag4 = 1,
                A4_ChZag5 = 0,
                A4_ChZag6 = 0,
                A4_ChZagO = 3,

                A5_ChZag = 57,
                A5_ChZag1 = 1,
                A5_ChZag2 = 1,
                A5_ChZag3 = 1,
                A5_ChZag4 = 1,
                A5_ChZag5 = 1,
                A5_ChZag6 = 0,
                A5_ChZagO = 4,

                A6_ChZag = 62,
                A6_ChZag1 = 0,
                A6_ChZag2 = 1,
                A6_ChZag3 = 2,
                A6_ChZag4 = 0,
                A6_ChZag5 = 0,
                A6_ChZag6 = 1,
                A6_ChZagO = 2,

                Isx_F = 267,
                Isx_R = 230,
            };

            return View(dataViewModel);  
        }
        //[HttpGet]
        //public IActionResult Result(DataViewModel dataViewModel)
        //{
        //    var resultViewModel = new ResultsViewModel(dataViewModel);

        //    //if (resultViewModel.SolverFunc() == true)
        //    //{
        //    //    return View(resultViewModel);
        //    //}
        //    //else
        //    //{
        //    //    return RedirectToAction(nameof(FSolver));
        //    //}
        //}
        [HttpGet]
        public IActionResult Report(DataViewModel dataViewModel)
        {
            var resultViewModel = new ResultsViewModel(dataViewModel);

            return View(resultViewModel);
        }

        [HttpGet]
        public IActionResult FSolver()
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
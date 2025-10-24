using CaoThiThanhXuan_231230966_de01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Diagnostics;

namespace CaoThiThanhXuan_231230966_de01.Controllers
{
    public class CaoThiThanhXuanHomeController : Controller
    {
        private readonly ILogger<CaoThiThanhXuanHomeController> _logger;

        public CaoThiThanhXuanHomeController(ILogger<CaoThiThanhXuanHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult CaoThiThanhXuanIndex()
        {
            return View("CaoThiThanhXuanIndex");
        }

        public IActionResult CaoThiThanhXuanPrivacy()
        {
            return View("CaoThiThanhXuanPrivacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult ShowDataTables()
        {
            Device device = new Device();
            return View(device);
        }
        public IActionResult Index()
        {
            return View();
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
        [HttpPost]
        public ActionResult GetDevices()
        {
            var result = new List<Device>();
            result.Add(new Device { Id = 1, ItemDescription = "華碩", ItemName = "電腦" });
            result.Add(new Device { Id = 2, ItemDescription = "蘋果", ItemName = "手機" });
            return Json(result);
        }
        [HttpGet]
        public ActionResult Edit(string temp)
        {
            var result = new List<Device>();
            result.Add(new Device { Id = 1, ItemDescription = "華碩", ItemName = "電腦" });
            result.Add(new Device { Id = 2, ItemDescription = "蘋果", ItemName = "手機" });
            var result2 = result.Where(c => c.ItemDescription == temp).FirstOrDefault();

            return PartialView("_PartialViewEdit", result2);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Device DevicesDto)
        {
            return Json("");
        }
    }
}
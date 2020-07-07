using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GoBear.Models;
using System.Net.WebSockets;

namespace GoBear.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult LoadData()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(GoBear.Models.StoreContext)) as StoreContext;
            var insurrance = context.GetAllInsu();
            var bank = context.GetAllBank();
            var data = from i in insurrance
                       join b in bank on i.id_Bank equals b.id_Bank
                       select new
                       {
                           i,
                           b
                       };
            return new JsonResult(data);
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
    }
}

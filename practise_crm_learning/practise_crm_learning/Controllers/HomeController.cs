using System.Diagnostics;
using SysActivity = System.Diagnostics.Activity;
using Microsoft.AspNetCore.Mvc;
using practise_crm_learning.Models;

namespace practise_crm_learning.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Pricing()
        {
            var plans = SubscriptionPlan.GetAllPlans();
            return View(plans);
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View(new ContactPageModel());
        }

        [HttpPost]
        public IActionResult Contact(ContactPageModel model)
        {
            if (ModelState.IsValid)
            {
                model.MessageSent = true;
                TempData["Success"] = $"Thank you {model.Name}! Your message has been sent. We'll respond within 24 hours.";
            }
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = SysActivity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

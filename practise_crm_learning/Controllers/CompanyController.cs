using Microsoft.AspNetCore.Mvc;
using practise_crm_learning.Models;

namespace practise_crm_learning.Controllers
{
    public class CompanyController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View(new CompanyRegisterViewModel());
        }

        [HttpPost]
        public IActionResult Register(CompanyRegisterViewModel model)
        {
            if (model.Password != model.ConfirmPassword)
                ModelState.AddModelError("ConfirmPassword", "Passwords do not match.");

            if (ModelState.IsValid)
            {
                TempData["Success"] = $"Welcome to UbuntuCRM! Your company '{model.CompanyName}' has been registered. Please check your email to activate your account.";
                return RedirectToAction("RegisterSuccess");
            }
            return View(model);
        }

        public IActionResult RegisterSuccess()
        {
            return View();
        }

        public IActionResult Profile()
        {
            var company = new Company
            {
                Id = 1,
                Name = "Ubuntu Motors Car Wash",
                RegistrationNumber = "2018/123456/07",
                Email = "info@ubuntumotors.co.za",
                Phone = "+27 11 555 9090",
                Website = "www.ubuntumotors.co.za",
                Address = "12 Mandela Drive",
                City = "Johannesburg",
                Province = "Gauteng",
                PostalCode = "2001",
                Sector = Sector.CarWash,
                Description = "Premium car wash and detailing services serving Gauteng and beyond. CIPC registered, B-BBEE Level 2 compliant.",
                SubscriptionTier = SubscriptionTier.Professional,
                EmployeeCount = 47,
                AnnualRevenue = 8500000,
                ServicesOffered = new() { "Full Service Wash", "Premium Detailing", "Fleet Contracts", "Mobile Wash Units", "Engine Cleaning" }
            };
            return View(company);
        }
    }
}

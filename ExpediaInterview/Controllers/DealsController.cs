using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpediaInterview.Models;
using ExpediaInterview.REST;
using Microsoft.AspNetCore.Mvc;
using ExpediaInterview.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExpediaInterview.Controllers
{
    public class DealsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var url = TempData["url"];

            if (url != null && !string.IsNullOrEmpty(url.ToString()))
            {
                ViewData["deal"] = RequestManager.GetDeal(url.ToString());
            }

            return View();
        }

        [HttpPost]
        public IActionResult Index(
            [Bind("Scenario,Page,Uid")] QueryParametersViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var viewUrl = TargetURL.GenerateURL(viewModel.ToDictionary());
                TempData["url"] = viewUrl;
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}

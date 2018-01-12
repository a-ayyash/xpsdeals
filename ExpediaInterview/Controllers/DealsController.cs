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
        public IActionResult Index(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                url = TargetURL.GenerateDefaultURL();
            }

            ViewData["deal"] = RequestManager.GetDeal(url);

            return View();
        }

        public IActionResult RequestDeals(QueryParametersViewModel viewModel)
        {
            var viewUrl = TargetURL.GenerateURL(viewModel.ToDictionary());
            return RedirectToAction("Index", new { url = viewUrl });
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

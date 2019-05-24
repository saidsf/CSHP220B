using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_06.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Models.BdCard cardRequest)
        {
            if (ModelState.IsValid)
                return View("CardSent", cardRequest);
            else
                return View();
        }
    }
}
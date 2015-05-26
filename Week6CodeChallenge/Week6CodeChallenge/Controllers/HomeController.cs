using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week6CodeChallenge.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            else
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            else
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            else
            return View();
        }

        [HttpPost]
        public ActionResult Contact(Models.ContactEmail app)
        {
            if (Request.IsAjaxRequest())
                return PartialView("ThankYou");
            return View("ThankYou");
        }

        public ActionResult Work()
        {
            ViewBag.Message = "Your work page.";
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            else
            return View();
        }


        public ActionResult Careers()
        {
            ViewBag.Message = "Your Careers page.";

            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            else
                return View();
        }

    }
}
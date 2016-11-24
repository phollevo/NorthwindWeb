using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddProvider()
        {
            ViewBag.Message = "Your Provider.";

            return View("~/Views/Home/Provider.cshtml");
        }

        public ActionResult AddCat()
        {
            ViewBag.Message = "Your category page.";

            return View("~/Views/Home/Category.cshtml"); ;
        }

        public ActionResult AddProd()
        {
            ViewBag.Message = "Your product page.";

            return View("~/Views/Home/Product.cshtml"); ;
        }
    }
}
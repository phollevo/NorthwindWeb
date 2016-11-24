using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindWeb.Controllers
{
    public class SupplierController : Controller
    {

        public ActionResult SupplierRedirect(String AccessType)
        {
            if (AccessType == "SupplierResearch")
            {
                return View("~/Views/Supplier/SupplierResearch.cshtml");
            }
            else
            {
                return View("~/Views/Supplier/SupplierDetail.cshtml");
            }
            //return View("~/Views/Home/SupplierRem.cshtml");
        }
        // GET: Supplier
        public ActionResult Index()
        {
            return View();
        }
    }
}
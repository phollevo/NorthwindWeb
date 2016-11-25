using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindWeb.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult ProductRedirect(String AccessType)
        {
            if (AccessType == "AddProduct")
            {
                return View("~/Views/Product/ProductAdd.cshtml");
            }
            else
            {
                return View("~/Views/Product/ProductRem.cshtml");
            }
            //return View("~/Views/Home/SupplierRem.cshtml");
        }

        public ActionResult AddProduct()
        {

            return View("~/Views/Product/ProductAdd.cshtml");
        }

        public ActionResult DelProduct()
        {
            return View("~/Views/Product/ProductRem.cshtml");
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindWeb.Controllers
{
    public class CatController : Controller
    {


        public ActionResult CatRedirect(String AccessType)
        {
            if (AccessType == "AddCat")
            {
                return View("~/Views/Cat/CategoryAdd.cshtml");
            }
            else
            {
                return View("~/Views/Cat/CategoryRem.cshtml");
            }
            //return View("~/Views/Home/SupplierRem.cshtml");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindWeb.Controllers
{
    public class CategoryController : Controller
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


        public ActionResult AddCategory()
        {

            return View("~/Views/Category/CategoryAdd.cshtml");
        }

        public ActionResult DelCategory()
        {
            return View("~/Views/Category/CategoryRem.cshtml");
        }
    }
}
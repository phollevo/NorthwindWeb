using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindWeb.Controllers
{
    public class SupplierController : Controller
    {

        [HttpPost]
        public ActionResult Search(String search)
        {
            Libraries.SupplierClient Client = new Libraries.SupplierClient();
            var suppliers = Client.searchSuppliers(search);

            return View("~/Views/Supplier/SupplierSearch.cshtml", suppliers);
        }

        public ActionResult SupplierRedirect(String AccessType)
        {
            if (AccessType == "SupplierSearch")
            {

                return View("~/Views/Supplier/SupplierSearch.cshtml");
            }
            else 
            {
                return View("~/Views/Supplier/SupplierAdd.cshtml");
            }
            //return View("~/Views/Home/SupplierRem.cshtml");
        }

     
        public ActionResult SupplierAdd()
        {

            return View("~/Views/Supplier/SupplierAdd.cshtml"); 
        }

        public ActionResult SupplierSearch()
        {
            return View("~/Views/Supplier/SupplierSearch.cshtml");
        }

        // GET: Supplier
        public ActionResult Index()
        {
            return View();
        }
    }
}
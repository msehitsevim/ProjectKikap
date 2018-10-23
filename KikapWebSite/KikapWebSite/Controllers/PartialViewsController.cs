using KikapWebSite.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace KikapWebSite.Controllers
{
    public class PartialViewsController : Controller
    {
       
        ProductConcrete pc = new ProductConcrete();

     
        //[ChildActionOnly]
        public ActionResult LastProduct()
        {
            return View(pc.GetLastProduct());
        }
        public ActionResult Product()
        {
            return View(pc.Product());
        }

    }
}
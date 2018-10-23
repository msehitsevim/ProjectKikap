using KikapWebSite.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KikapWebSite.Controllers
{

    public class AuthorController : Controller
    {
        AuthorList al = new AuthorList();
        public ActionResult Author()
        {
            return View(al.author());
        }
    }
}
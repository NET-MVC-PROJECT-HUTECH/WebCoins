using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMain.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult getmenu()
        {
            return PartialView();
        }
        public ActionResult Topbar()
        {
            return PartialView();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMain.Controllers
{
    public class TabsController : Controller
    {
        // GET: Tabs
        public ActionResult Index()
        {
            return View();
        }
    }
}
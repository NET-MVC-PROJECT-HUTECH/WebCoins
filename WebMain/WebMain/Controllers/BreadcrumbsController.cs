using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMain.Controllers
{
    public class BreadcrumbsController : Controller
    {
        // GET: Breadcrumbs
        public ActionResult Index()
        {
            return View();
        }
    }
}
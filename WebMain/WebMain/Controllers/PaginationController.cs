using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMain.Controllers
{
    public class PaginationController : Controller
    {
        // GET: Pagination
        public ActionResult Index()
        {
            return View();
        }
    }
}
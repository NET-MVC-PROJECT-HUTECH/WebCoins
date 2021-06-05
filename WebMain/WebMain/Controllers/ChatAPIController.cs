using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMain.Controllers
{
    public class ChatAPIController : Controller
    {
        // GET: ChatAPI
        public ActionResult Index()
        {
            return View();
        }
    }
}
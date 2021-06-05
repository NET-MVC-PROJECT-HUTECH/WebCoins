using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMain.Controllers
{
    public class MailViewController : Controller
    {
        // GET: MailView
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MailSent()
        {
            return View();
        }
        public ActionResult MailDrafts()
        {
            return View();
        }
        public ActionResult Important()
        {
            return View();
        }
        public ActionResult Trash()
        {
            return View();
        }
    }
}
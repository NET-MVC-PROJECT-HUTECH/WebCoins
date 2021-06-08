using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMain.Models;

namespace WebMain.Controllers
{
    public class UILoginController : Controller
    {
        private egvietnam_dbEntities db = new egvietnam_dbEntities();

        // GET: UILogin
        public ActionResult Index()
        {
            return View();
        }

        //Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(AspNetUser reg)
        {
            if (ModelState.IsValid)
            {
                db.AspNetUsers.Add(reg);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
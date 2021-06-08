using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebMain.Models;

namespace WebMain.Controllers
{
    public class UILoginController : Controller
    {
        egvietnam_dbEntities db = new egvietnam_dbEntities();
        // GET: UILogin
        public ActionResult Index()
        {
            
            ViewBag.Error = "";
            return View();
        }
        
        [HttpPost]

        public ActionResult Index(FormCollection field)
        {
            string sterror = "";
            string email = field["email"];
            string password = field["password"];
            string passEncode = MD5Hash(Base64Encode(password));
            var rowuer = db.AspNetUsers.Where(m => m.Email == email).FirstOrDefault();
            if(rowuer == null)
            {
                sterror = "Tên đăng nhập không tồn tại";
            }
            else
            {
                if(rowuer.PasswordHash.Equals(passEncode))
                {
                    return RedirectToAction("Indexdashboard", "Dashboard");
                }

                else
                {
                    sterror = "Mật khẩu không đúng!";
                }
            }

            ViewBag.Error = "<span class='text-danger'>" +sterror+ "</span>";
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
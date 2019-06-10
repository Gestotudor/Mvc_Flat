using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlatMVC.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string pass)
        {
            if(username=="admin" && pass == "123456")
            {
                Session["Giris"] = true;
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Logout()
        {
            Session["Giris"] = null;
            return RedirectToAction("Login");
        }
    }
}
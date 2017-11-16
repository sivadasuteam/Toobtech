using StudentRegistrationPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Register()
        {
            ViewBag.Message = "Your registration page.";

            return View();
        }
        public bool CheckUser(string uid, string pwd)
        {
            Registration obj = new Registration();
            bool res = obj.IsValid(uid, pwd);

            return res;
        }
        public student UserDetails(student std)
        {
            //
            student obj = std;
            return obj;
        }

        internal class Registration
        {
            public Registration()
            {
            }

            internal bool IsValid(string uid, string pwd)
            {
                throw new NotImplementedException();
            }
        }
    }
}
        



   
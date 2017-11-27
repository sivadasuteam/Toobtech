using MyNamespace;
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
        public ActionResult Registration()
        {
            ViewBag.Message = "Your Registration page.";

            return View();
        }
        public bool CheckUser(string uid,string pwd, string address, string phno)
        {
            register_yunus obj = new register_yunus();
            bool res = obj.IsValid(uid, pwd,address,phno);

            return res;
        }
        public student UserDetails(student std  )
        {
            //
            student obj = std;
            return obj;
            
        }
    }
}
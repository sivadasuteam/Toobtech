using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class SrikanthController : Controller
    {
        // GET: Srikanth
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult New()
        {
            return View();
        }
    }
}
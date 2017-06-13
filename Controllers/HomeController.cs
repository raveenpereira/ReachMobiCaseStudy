using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Collections;
using SecondCS.DAO;


namespace SecondCS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {   Console.WriteLine("I am here");

            //MyDB mydb = new MyDB();
			
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            return View();
        }
		public ActionResult New()
		{
			Console.WriteLine("I am here");

			//MyDB mydb = new MyDB();

			var mvcName = typeof(Controller).Assembly.GetName();
			var isMono = Type.GetType("Mono.Runtime") != null;

			ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData["Runtime"] = isMono ? "Mono" : ".NET";

			return View();
		}
    }
}

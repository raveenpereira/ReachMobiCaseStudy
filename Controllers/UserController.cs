using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecondCS.DAO;

namespace ThirdEntity.Controllers
{
    public class UserController : Controller
    {

        [HttpPost]
        public ActionResult Add(int zip, String email, String remember=null)
        {
            Console.WriteLine(zip);
            Console.WriteLine(email);
            Console.WriteLine(remember);

            if(email.Length==0){
                MyDB mydb = new MyDB(zip, remember);
            }else{
                MyDB mydb = new MyDB(zip, email, remember);
            }
            //return View ();
            return Redirect(Request.UrlReferrer.PathAndQuery);
        }
		[HttpPost]
		public ActionResult New(int zip, String remember = null)
		{
			Console.WriteLine(zip);
			Console.WriteLine(remember);

				MyDB mydb = new MyDB(zip, remember);
	
			//return View ();
			return Redirect(Request.UrlReferrer.PathAndQuery);
		}
    }
}

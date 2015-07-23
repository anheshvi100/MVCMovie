using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
       
        
        public ActionResult Index( )
        {
           


            return View();
        }
       
        
        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //} 

        public ActionResult Welcome(string name, int numTimes = 5)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;
            return View ();
            //return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        }

        //public string Welcome(string name, int ID = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        //}
        //public string Welcome(string name, int ID = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        //}
           
        } 
    
}
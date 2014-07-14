using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieApplication.Controllers
{
    public class GreetingsController : Controller
    {
        // GET: Greetings
        public ActionResult Index()
        {
            return View();
        }

        //GET: Welcome
        //public ActionResult Welcome()
        //{
        //    ViewBag.Message = "Hello" + name;
        //    ViewBag.NumTimes = numTimes;
        //    return View();
        //}
    }
}
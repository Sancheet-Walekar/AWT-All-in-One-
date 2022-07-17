using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GreetingAppMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            //Dynamic view
            //Fetch view
            int hour = DateTime.Now.Hour;
            if(hour < 12)
            {
                ViewBag.Greeting = "Good Morning!";
            }
            else if(hour < 16)
            {
                ViewBag.Greeting = "Good Afternoon";
            }
            else
            {
                ViewBag.Greeting = "Good Evening";
            }
            return View();
        }
        public ViewResult RspvForm()
        {
            return View();
        }
    }
}
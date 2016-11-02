using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoFront.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome. Please go to the API Interaction page to test the API.";

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Contoso Contact Page";

            return View();
        }
    }
}
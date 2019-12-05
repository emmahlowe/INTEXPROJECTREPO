using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INTEXPROJECT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title="Northwest Labs";
            return View();
        }

        public ActionResult LogIn()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();

        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult OrderStatus()
        {
            return View();
        }

        public ActionResult OrderHistory()
        {
            return View();
        }

        public ActionResult CheckIn()
        {

            return View();
        }

        public ActionResult CheckOut()
        {

            return View();
        }
    }
}
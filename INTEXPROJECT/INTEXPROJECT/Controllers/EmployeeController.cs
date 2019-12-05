using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INTEXPROJECT.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            ViewBag.Title = "Northwest Labs";
            return View();
        }

        public ActionResult Mangement()
        {
            return View();
        }
    }
}
using INTEXPROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INTEXPROJECT.Controllers
{
    public class OrderController : Controller
    {
        public static List<AssayDescriptions> lstAssays = new List<AssayDescriptions>()
        {
            new AssayDescriptions{Assay_Description_ID = 1, Price_ID = 1, Type_ID = 1, Description = "Biochemical Pharmacology", Protocol = "Test Protocol", Completion_Time = 300, Literature_References="Something"},
            new AssayDescriptions{Assay_Description_ID = 2, Price_ID = 1, Type_ID = 1, Description = "DiscoveryScreen", Protocol = "Test Protocol", Completion_Time = 300, Literature_References="Something"},
            new AssayDescriptions{Assay_Description_ID = 3, Price_ID = 1, Type_ID = 1, Description = "ImmunoScreen", Protocol = "Test Protocol", Completion_Time = 300, Literature_References="Something"},
            new AssayDescriptions{Assay_Description_ID = 4, Price_ID = 1, Type_ID = 1, Description = "ProfilingScreen", Protocol = "Test Protocol", Completion_Time = 300, Literature_References="Something"},
            new AssayDescriptions{Assay_Description_ID = 5, Price_ID = 1, Type_ID = 1, Description = "PharmaScreen", Protocol = "Test Protocol", Completion_Time = 300, Literature_References="Something"},
            new AssayDescriptions{Assay_Description_ID = 6, Price_ID = 1, Type_ID = 1, Description = "CustomScreen", Protocol = "Test Protocol", Completion_Time = 300, Literature_References="Something"}
        };

        public static List<CompoundDescriptions> lstCompounds = new List<CompoundDescriptions>()
        {
            new CompoundDescriptions{Compound_ID = 1, Name = "Serotonin"},
            new CompoundDescriptions{Compound_ID = 1, Name = "Atropine"},
            new CompoundDescriptions{Compound_ID = 1, Name = "Tyrosine"},
            new CompoundDescriptions{Compound_ID = 1, Name = "Quinine"},
            new CompoundDescriptions{Compound_ID = 1, Name = "Phenobarbital"}
        };

        public static List<Priorities> lstPriorities = new List<Priorities>()
        {
            new Priorities{Priority_ID = 1, Description = "Standard (7 to 10 weeks) - $0.00"},
            new Priorities{Priority_ID = 2, Description = "Priority (5 to 7 weeks) - $100.00"},
            new Priorities{Priority_ID = 3, Description = "Rushed (3 weeks to 5 weeks) - $200.00"}
        };

        // GET: Order
        public ActionResult Index()
        {
            ViewBag.Compounds = lstCompounds;
            ViewBag.Assays = lstAssays;
            ViewBag.Priorities = lstPriorities;
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Compounds = lstCompounds;
            ViewBag.Assays = lstAssays;
            ViewBag.Priorities = lstPriorities;
            return View();
        }

        [HttpPost]
        public ActionResult Create(string compName1, string compWeight1, string assayTest1)
        {
            //get number of assays per compound
            //get number of compounds
            //get what compounds and what assays are needed

            //create work order record
            //create compound record(s)
            //create assay record(s)
            ViewBag.Compounds = lstCompounds;
            ViewBag.Assays = lstAssays;
            ViewBag.Priorities = lstPriorities;
            return View();
        }
        public static int numCompounds = 0;

        public ActionResult AddAssay()
        {

            ViewBag.Compounds = lstCompounds;
            ViewBag.Assays = lstAssays;
            ViewBag.Priorities = lstPriorities;
            return View("Create");
        }

        public ActionResult AddCompound()
        {
            numCompounds += 1;
            for (int iCount = 0; iCount < numCompounds; iCount++)
            {
                ViewBag.addCompound += "<h5> Compound " + (iCount + 2) + " </h5> " +
            "<label for= 'compName" + (iCount + 2) + "'>Compound Name</label> " +
            "<select name='compName" + (iCount + 2) + " > " +
                "<option value='0'>Serotonin</option> " +
                "<option value='1'>Atropine</option> " +
                "<option value='2'>Tyrosine</option> " +
                "<option value='3'>Quinine</option> " +
                 "<option value='4'>Phenobarbital</option> " +
            "  </select> " +

            "<br />" +

             "<label for= 'compWeight" + (iCount + 2) + "'>Compound Weight</label> " +
             "<input type='text' name='compWeight" + (iCount + 2) + "' /> " +
             "<br />" +
              "<label for= 'assayTest" + (iCount + 2) + ".2" + "'>Assay Test 1 </label> " +
            "<select name='assayTest" + (iCount + 2) + ".2" + "'> " +
                "<option value='2'>Biochemical Pharmacology</option> " +
                "<option value='3'>DiscoveryScreen</option> " +
                "<option value='4'>ImmunoScreen</option> " +
                "<option value='5'>ProfilingScreen</option> " +
                "<option value='6'>PharmaScreen</option> " +
                "<option value='7'>CustomScreen</option> " +
            "  </select> <br />";

                for (int inCount = 3; inCount < 8; inCount++)
                {
                    ViewBag.addCompound += "<label for= 'assayTest" + (iCount + 2) + "." + inCount + "'>Assay Test" + (inCount - 1) + " </label> " +
            "<select name='assayTest" + (iCount + 2) + "." + inCount + "'> " +
                "<option value='1'>No additional tests</option> " +
                "<option value='2'>Biochemical Pharmacology</option> " +
                "<option value='3'>DiscoveryScreen</option> " +
                "<option value='4'>ImmunoScreen</option> " +
                "<option value='5'>ProfilingScreen</option> " +
                "<option value='6'>PharmaScreen</option> " +
                "<option value='7'>CustomScreen</option> " +
            "  </select> <br />";
                }
            }
            ViewBag.Compounds = lstCompounds;
            ViewBag.Assays = lstAssays;
            ViewBag.Priorities = lstPriorities;
            return View("Create");
        }

        [HttpPost]
        public ActionResult AddAssay(string compName1, string compWeight1, string assayTest1, string compName2, string compWeight2, string assayTest2, string compName3, string compWeight3, string assayTest3, string compName4, string compWeight4, string assayTest4, string compName5, string compWeight5, string assayTest5)
        {
            
            ViewBag.Compounds = lstCompounds;
            ViewBag.Assays = lstAssays;
            ViewBag.Priorities = lstPriorities;
            return View("Create");
        }
    }
}
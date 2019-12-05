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

        //[HttpPost]
        //public ActionResult Create(string compName1, string compWeight1, string assayTest1)
        //{

        //    ViewBag.Compounds = lstCompounds;
        //    ViewBag.Assays = lstAssays;
        //    ViewBag.Priorities = lstPriorities;
        //    return View();
        //}
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
            "<select name='compName" + (iCount + 2) + "' > " +
                "<option value='1'>Serotonin</option> " +
                "<option value='2'>Atropine</option> " +
                "<option value='3'>Tyrosine</option> " +
                "<option value='4'>Quinine</option> " +
                 "<option value='5'>Phenobarbital</option> " +
            "  </select> " +

            "<br />" +

             "<label for= 'compWeight" + (iCount + 2) + "'>Compound Weight in ML</label> " +
             "<input type='text' name='compWeight" + (iCount + 2) + "' /> " +
             "<br />" +
              "<label for= 'assayTest" + (iCount + 2) + "_1" + "'>Assay Test 1 </label> " +
            "<select name='assayTest" + (iCount + 2) + "_1" + "'> " +
                "<option>Biochemical Pharmacology</option> " +
                "<option>DiscoveryScreen</option> " +
                "<option>ImmunoScreen</option> " +
                "<option>ProfilingScreen</option> " +
                "<option>PharmaScreen</option> " +
                "<option>CustomScreen</option> " +
            "  </select> <br />";

                for (int inCount = 3; inCount < 8; inCount++)
                {
                    ViewBag.addCompound += "<label for= 'assayTest" + (iCount + 2) + "_" + (inCount - 1) + "'>Assay Test " + (inCount - 1) + " </label> " +
            "<select name='assayTest" + (iCount + 2) + "_" + (inCount - 1) + "'> " +
                "<option>No additional tests</option> " +
                "<option>Biochemical Pharmacology</option> " +
                "<option>DiscoveryScreen</option> " +
                "<option>ImmunoScreen</option> " +
                "<option>ProfilingScreen</option> " +
                "<option>PharmaScreen</option> " +
                "<option>CustomScreen</option> " +
            "  </select> <br />";
                }
            }
            ViewBag.Compounds = lstCompounds;
            ViewBag.Assays = lstAssays;
            ViewBag.Priorities = lstPriorities;
            return View("Create");
        }

        [HttpPost]
        public ActionResult getOrderQuote(string priority, string compName1, decimal compWeight1, string compName2, string compName3, string compName4, string compName5, string assayTest1_1, string assayTest1_2, string assayTest1_3, string assayTest1_4, string assayTest1_5, string assayTest1_6, string assayTest2_1, string assayTest2_2, string assayTest2_3, string assayTest2_4, string assayTest2_5, string assayTest2_6, string assayTest3_1, string assayTest3_2, string assayTest3_3, string assayTest3_4, string assayTest3_5, string assayTest3_6, string assayTest4_1, string assayTest4_2, string assayTest4_3, string assayTest4_4, string assayTest4_5, string assayTest4_6, string assayTest5_1, string assayTest5_2, string assayTest5_3, string assayTest5_4, string assayTest5_5, string assayTest5_6, decimal compWeight2 = 0, decimal compWeight3 = 0, decimal compWeight4 = 0, decimal compWeight5 = 0)
        {
            //calculate quote
            //create work order object
            //create assay objects
            //create compound objects

            //get number of assays per compound
            //get number of compounds
            //get what compounds and what assays are needed

            //create work order record
            //create compound record(s)
            //create assay record(s)
            decimal OrderQuote;
            //adds priority on
            if(priority == "1")
            {
                OrderQuote = 0m;
            }
            else if(priority == "2")
            {
                OrderQuote = 500m;
            }
            else
            {
                OrderQuote = 1000m;
            }

            //adds comp1 assaytest1 cost on
            if (assayTest1_1 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight1));
            }

            else if (assayTest1_1 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight1));
            }

            else if (assayTest1_1 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight1));
            }

            else if (assayTest1_1 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight1));
            }

            else if (assayTest1_1 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight1));
            }

            else if (assayTest1_1 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight1));
            }

            //---------------------adds comp1 assaytest2 cost on
            if (assayTest1_2 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight1));
            }
           else if (assayTest1_2 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight1));
            }

            else if (assayTest1_2 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight1));
            }

            else if (assayTest1_2 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight1));
            }

            else if (assayTest1_2 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight1));
            }

            else if (assayTest1_2 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight1));
            }

            //---------------------adds comp1 assaytest3 cost on
            if (assayTest1_3 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight1));
            }
            else if (assayTest1_3 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight1));
            }

            else if (assayTest1_3 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight1));
            }

            else if (assayTest1_3 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight1));
            }

            else if (assayTest1_3 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight1));
            }

            else if (assayTest1_3 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight1));
            }

            //---------------------adds comp1 assaytest4 cost on
            if (assayTest1_4 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight1));
            }
            else if (assayTest1_4 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight1));
            }

            else if (assayTest1_4 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight1));
            }

            else if (assayTest1_4 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight1));
            }

            else if (assayTest1_4 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight1));
            }

            else if (assayTest1_4 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight1));
            }

            //---------------------adds comp1 assaytest5 cost on
            if (assayTest1_5 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight1));
            }
            else if (assayTest1_5 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight1));
            }

            else if (assayTest1_5 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight1));
            }

            else if (assayTest1_5 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight1));
            }

            else if (assayTest1_5 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight1));
            }

            else if (assayTest1_5 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight1));
            }

            //---------------------adds comp1 assaytest6 cost on
            if (assayTest1_6 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight1));
            }
            else if (assayTest1_6 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight1));
            }

            else if (assayTest1_6 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight1));
            }

            else if (assayTest1_6 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight1));
            }

            else if (assayTest1_6 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight1));
            }

            else if (assayTest1_6 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight1));
            }

            //-------------COMPOUND 2---------------------
            //
            //
            //
            //
            //
            //-------------COMPOUND 2---------------------

            //adds comp2 assaytest2 cost on
            if (assayTest2_1 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight2));
            }

            else if (assayTest2_1 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight2));
            }

            else if (assayTest2_1 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight2));
            }

            else if (assayTest2_1 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight2));
            }

            else if (assayTest2_1 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight2));
            }

            else if (assayTest2_1 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight2));
            }

            //---------------------adds comp2 assaytest2 cost on
            if (assayTest2_2 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight2));
            }
            else if (assayTest2_2 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight2));
            }

            else if (assayTest2_2 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight2));
            }

            else if (assayTest2_2 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight2));
            }

            else if (assayTest2_2 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight2));
            }

            else if (assayTest2_2 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight2));
            }

            //---------------------adds comp2 assaytest3 cost on
            if (assayTest2_3 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight2));
            }
            else if (assayTest2_3 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight2));
            }

            else if (assayTest2_3 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight2));
            }

            else if (assayTest2_3 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight2));
            }

            else if (assayTest2_3 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight2));
            }

            else if (assayTest2_3 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight2));
            }

            //---------------------adds comp2 assaytest4 cost on
            if (assayTest2_4 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight2));
            }
            else if (assayTest2_4 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight2));
            }

            else if (assayTest2_4 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight2));
            }

            else if (assayTest2_4 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight2));
            }

            else if (assayTest2_4 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight2));
            }

            else if (assayTest2_4 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight2));
            }

            //---------------------adds comp2 assaytest5 cost on
            if (assayTest2_5 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight2));
            }
            else if (assayTest2_5 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight2));
            }

            else if (assayTest2_5 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight2));
            }

            else if (assayTest2_5 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight2));
            }

            else if (assayTest2_5 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight2));
            }

            else if (assayTest2_5 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight2));
            }

            //---------------------adds comp2 assaytest6 cost on
            if (assayTest2_6 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight2));
            }
            else if (assayTest2_6 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight2));
            }

            else if (assayTest2_6 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight2));
            }

            else if (assayTest2_6 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight2));
            }

            else if (assayTest2_6 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight2));
            }

            else if (assayTest2_6 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight2));
            }

            //-------------COMPOUND 3---------------------
            //
            //
            //
            //
            //
            //-------------COMPOUND 3---------------------

            //adds comp3 assaytest2 cost on
            if (assayTest3_1 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight3));
            }

            else if (assayTest3_1 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight3));
            }

            else if (assayTest3_1 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight3));
            }

            else if (assayTest3_1 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight3));
            }

            else if (assayTest3_1 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight3));
            }

            else if (assayTest3_1 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight3));
            }

            //---------------------adds comp3 assaytest2 cost on
            if (assayTest3_2 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight3));
            }
            else if (assayTest3_2 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight3));
            }

            else if (assayTest3_2 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight3));
            }

            else if (assayTest3_2 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight3));
            }

            else if (assayTest3_2 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight3));
            }

            else if (assayTest3_2 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight3));
            }

            //---------------------adds comp3 assaytest3 cost on
            if (assayTest3_3 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight3));
            }
            else if (assayTest3_3 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight3));
            }

            else if (assayTest3_3 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight3));
            }

            else if (assayTest3_3 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight3));
            }

            else if (assayTest3_3 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight3));
            }

            else if (assayTest3_3 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight3));
            }

            //---------------------adds comp3 assaytest4 cost on
            if (assayTest3_4 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight3));
            }
            else if (assayTest3_4 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight3));
            }

            else if (assayTest3_4 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight3));
            }

            else if (assayTest3_4 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight3));
            }

            else if (assayTest3_4 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight3));
            }

            else if (assayTest3_4 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight3));
            }

            //---------------------adds comp3 assaytest5 cost on
            if (assayTest3_5 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight3));
            }
            else if (assayTest3_5 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight3));
            }

            else if (assayTest3_5 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight3));
            }

            else if (assayTest3_5 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight3));
            }

            else if (assayTest3_5 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight3));
            }

            else if (assayTest3_5 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight3));
            }

            //---------------------adds comp3 assaytest6 cost on
            if (assayTest3_6 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight3));
            }
            else if (assayTest3_6 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight3));
            }

            else if (assayTest3_6 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight3));
            }

            else if (assayTest3_6 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight3));
            }

            else if (assayTest3_6 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight3));
            }

            else if (assayTest3_6 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight3));
            }
            //-------------COMPOUND 4---------------------
            //
            //
            //
            //
            //
            //-------------COMPOUND 4---------------------

            //adds comp4 assaytest2 cost on
            if (assayTest4_1 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight4));
            }

            else if (assayTest4_1 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight4));
            }

            else if (assayTest4_1 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight4));
            }

            else if (assayTest4_1 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight4));
            }

            else if (assayTest4_1 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight4));
            }

            else if (assayTest4_1 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight4));
            }

            //---------------------adds comp3 assaytest2 cost on
            if (assayTest4_2 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight4));
            }
            else if (assayTest4_2 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight4));
            }

            else if (assayTest4_2 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight4));
            }

            else if (assayTest4_2 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight4));
            }

            else if (assayTest4_2 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight4));
            }

            else if (assayTest4_2 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight4));
            }

            //---------------------adds comp4 assaytest3 cost on
            if (assayTest4_3 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight4));
            }
            else if (assayTest4_3 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight4));
            }

            else if (assayTest4_3 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight4));
            }

            else if (assayTest4_3 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight4));
            }

            else if (assayTest4_3 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight4));
            }

            else if (assayTest4_3 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight4));
            }

            //---------------------adds comp4 assaytest4 cost on
            if (assayTest4_4 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight4));
            }
            else if (assayTest4_4 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight4));
            }

            else if (assayTest4_4 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight4));
            }

            else if (assayTest4_4 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight4));
            }

            else if (assayTest4_4 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight4));
            }

            else if (assayTest4_4 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight4));
            }

            //---------------------adds comp4 assaytest5 cost on
            if (assayTest4_5 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight4));
            }
            else if (assayTest4_5 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight4));
            }

            else if (assayTest4_5 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight4));
            }

            else if (assayTest4_5 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight4));
            }

            else if (assayTest4_5 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight4));
            }

            else if (assayTest4_5 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight4));
            }

            //---------------------adds comp3 assaytest6 cost on
            if (assayTest4_6 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight4));
            }
            else if (assayTest4_6 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight4));
            }

            else if (assayTest4_6 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight4));
            }

            else if (assayTest4_6 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight4));
            }

            else if (assayTest4_6 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight4));
            }

            else if (assayTest4_6 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight4));
            }

            //-------------COMPOUND 5---------------------
            //
            //
            //
            //
            //
            //-------------COMPOUND 5---------------------

            //adds comp5 assaytest2 cost on
            if (assayTest5_1 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight5));
            }

            else if (assayTest5_1 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight5));
            }

            else if (assayTest5_1 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight5));
            }

            else if (assayTest5_1 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight5));
            }

            else if (assayTest5_1 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight5));
            }

            else if (assayTest5_1 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight5));
            }

            //---------------------adds comp5 assaytest2 cost on
            if (assayTest5_2 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight5));
            }
            else if (assayTest5_2 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight5));
            }

            else if (assayTest5_2 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight5));
            }

            else if (assayTest5_2 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight5));
            }

            else if (assayTest5_2 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight5));
            }

            else if (assayTest5_2 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight5));
            }

            //---------------------adds comp5 assaytest3 cost on
            if (assayTest5_3 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight5));
            }
            else if (assayTest5_3 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight5));
            }

            else if (assayTest5_3 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight5));
            }

            else if (assayTest5_3 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight5));
            }

            else if (assayTest5_3 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight5));
            }

            else if (assayTest5_3 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight5));
            }

            //---------------------adds comp5 assaytest4 cost on
            if (assayTest5_4 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight5));
            }
            else if (assayTest5_4 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight5));
            }

            else if (assayTest5_4 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight5));
            }

            else if (assayTest5_4 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight5));
            }

            else if (assayTest5_4 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight5));
            }

            else if (assayTest5_4 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight5));
            }

            //---------------------adds comp5 assaytest5 cost on
            if (assayTest5_5 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight5));
            }
            else if (assayTest5_5 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight5));
            }

            else if (assayTest5_5 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight5));
            }

            else if (assayTest5_5 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight5));
            }

            else if (assayTest5_5 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight5));
            }

            else if (assayTest5_5 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight5));
            }

            //---------------------adds comp5 assaytest6 cost on
            if (assayTest5_6 == "Biochemical Pharmacology")
            {
                OrderQuote = Decimal.Add(OrderQuote, 33.7m);
                OrderQuote = Decimal.Add(OrderQuote, (6.5m * compWeight5));
            }
            else if (assayTest5_6 == "DiscoveryScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.20m);
                OrderQuote = Decimal.Add(OrderQuote, (5.20m * compWeight5));
            }

            else if (assayTest5_6 == "ImmunoScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 27.90m);
                OrderQuote = Decimal.Add(OrderQuote, (6.30m * compWeight5));
            }

            else if (assayTest5_6 == "ProfilingScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 22.10m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight5));
            }

            else if (assayTest5_6 == "PharmaScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 19.80m);
                OrderQuote = Decimal.Add(OrderQuote, (7.10m * compWeight5));
            }

            else if (assayTest5_6 == "CustomScreen")
            {
                OrderQuote = Decimal.Add(OrderQuote, 37.50m);
                OrderQuote = Decimal.Add(OrderQuote, (6.40m * compWeight5));
            }

            ViewBag.Quote = '$' + Math.Round(OrderQuote, 2);
            ViewBag.Compounds = lstCompounds;
            ViewBag.Assays = lstAssays;
            ViewBag.Priorities = lstPriorities;
            return PartialView("Quote");
        }
    }
}
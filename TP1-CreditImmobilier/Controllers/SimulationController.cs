using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.Mvc;
using TP1_CreditImmobilier.Models;

namespace TP1_CreditImmobilier.Controllers
{
    public class SimulationController : Controller
    {
        public Simulation sml;
       
        
        public ActionResult Create() {
         
            return View("Create");

        }
    }
}
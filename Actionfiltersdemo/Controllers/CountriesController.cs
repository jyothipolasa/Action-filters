using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Actionfiltersdemo.Controllers
{
    public class CountriesController : Controller
    {
        // GET: Countries
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Countries(List<string> countrynames)
        {
            return View(countrynames);
        }
    }
}
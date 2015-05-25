using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Properties;

namespace WebApplication2.Controllers
{
    public class ProbabilityController : Controller
    {
        // GET: ProbabilityCalculator
		public ActionResult ProbabilityCalculator()
        {
			var title =  Resource.ResourceManager.GetString("Title_ProbabilityCalculator");

            return View();
        }
    }
}
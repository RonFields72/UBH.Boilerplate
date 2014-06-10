using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UBH.Boilerplate.Web.Controllers
{
    public class AboutController : UBH.BoilerplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
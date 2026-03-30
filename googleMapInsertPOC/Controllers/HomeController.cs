using googleMapInsertPOC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace googleMapInsertPOC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MapDataVM VM = new MapDataVM();
            return View(VM);
        }
        [HttpPost]
        public ActionResult MapExampleAdvanced(MapDataVM VM)
        {
            return View(VM);
        }

        [HttpPost]
        public ActionResult MapExampleSimple(MapDataVM VM)
        {
            return View(VM);
        }

    }
}
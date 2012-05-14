using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using mysite.Models;

namespace mysite.Controllers
{
    public class UniverseController : Controller
    {
        //
        // GET: /Universe/

        public ActionResult Galaxy()
        {
            List<Planet> planetList = new List<Planet>
            {

            };

            ViewBag.NumOfPlanet = planetList.Count;

            return View(planetList);
        }

    }
}

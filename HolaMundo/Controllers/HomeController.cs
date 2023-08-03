using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HolaMundo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Inicio()
        {
            return View("VistaUno");
        }

        public ActionResult VistaDos()
        {
            return View("VistaDos");
        }

        public ActionResult VistaTres()
        {
            return View("VistaTres");
        }
    }
}
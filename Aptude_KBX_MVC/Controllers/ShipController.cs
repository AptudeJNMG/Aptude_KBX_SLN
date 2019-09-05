using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aptude_KBX_MVC.Controllers
{
    [Authorize]
    public class ShipController : Controller
    {
        // GET: Ship
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Info(Guid GuidShip)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Arrived(Guid GuidShip)
        {
            return View();
        }
    }
}
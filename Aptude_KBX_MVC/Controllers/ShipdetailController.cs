using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aptude_KBX_MVC.Controllers
{
    [Authorize]
    public class ShipdetailController : Controller
    {
        // GET: Shipdetail
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Arrived(Guid IdShip)
        {
            if (Session["WareHouse"] != null)
            {
                return View();
            }
            return View();
        }
    }
}
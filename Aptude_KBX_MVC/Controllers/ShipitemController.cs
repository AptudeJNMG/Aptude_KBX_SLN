using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aptude_KBX_MVC.Controllers
{
    [Authorize]
    public class ShipitemController : Controller
    {
        // GET: Shipitem
        [ActionName ("Find")]
        public ActionResult BuscarPorCliente(int IdCliente)
        {
            return View();
        }

        [ActionName("Find")]
        public ActionResult BuscarPorGuid(Guid guid)
        {
            return View();
        }
    }
}
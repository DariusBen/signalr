using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace tpsignalr.aplicacion.Controllers
{
    public class MovimientoController : Controller
    {

        public IActionResult Movimiento()
        {
            return View();
        }
    }
}

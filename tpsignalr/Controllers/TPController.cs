using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace tpsignalr.aplicacion.Controllers
{
    public class TPController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using tpsignalr.aplicacion.Models;
using tpsignalr.Servicios;

namespace tpsignalr.aplicacion.Controllers
{
    public class ChatController : Controller
    {

        private readonly ILogger<ChatController> Logger;
        private readonly IServicioSalas _ServicioSalas;

        public ChatController(IServicioSalas ServicioSalas,
                                ILogger<ChatController> logger)
        {
            this.Logger = logger;
            this._ServicioSalas = ServicioSalas;
        }

        public IActionResult Inicio()
        {

            Usuario usuarioActual = new Usuario();
            
            usuarioActual.Salas = this.ObtenerSalas();

            return View(usuarioActual);
        }

        [HttpPost]
        public IActionResult SalaChat(Usuario usuario)
        {

            usuario.Salas = this.ObtenerSalas();

            return View(usuario);
        }

        private List<SelectListItem> ObtenerSalas()
        {
            return this._ServicioSalas.ObtenerSalas()
                                                    .Select(x => new SelectListItem() { Text = x.Nombre, Value = x.Id.ToString() })?
                                                    .ToList() ?? new List<SelectListItem>();
        }
    }
}

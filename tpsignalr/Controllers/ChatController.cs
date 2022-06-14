using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using signalrtpsignalr.aplicacion.hubs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tpsignalr.aplicacion.Models;
using tpsignalr.Modelos;
using tpsignalr.Servicios;

namespace tpsignalr.aplicacion.Controllers
{
    public class ChatController : Controller
    {

        private readonly ILogger<ChatController> _Logger;
        private readonly IServicioSalas _ServicioSalas;
        private readonly IHubContext<ChatHub> _hubContext;

        public ChatController(IServicioSalas ServicioSalas,
                              ILogger<ChatController> logger,
                              IHubContext<ChatHub> hubContext  )
        {
            _Logger = logger;
            _ServicioSalas = ServicioSalas;
            _hubContext = hubContext;

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


        [HttpPost]
        public IActionResult RegistrarNuevaSala(Sala nuevaSala)
        {
            _ServicioSalas.RegistrarSala(nuevaSala);

            _hubContext.Clients.All.SendAsync("ReceiveNews", "Se ha abierto una nueva Sala: " + nuevaSala.Nombre);

            return Ok();
        }

        private List<SelectListItem> ObtenerSalas()
        {
            return this._ServicioSalas.ObtenerSalas()
                                                    .Select(x => new SelectListItem() { Text = x.Nombre, Value = x.Id.ToString() })?
                                                    .ToList() ?? new List<SelectListItem>();
        }
    }
}

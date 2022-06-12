using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using tpsignalr.Modelos;

#nullable disable

namespace tpsignalr.aplicacion.Models
{
    public partial class Usuario
    {
        public string Nombre { get; set; }
        public int SalaSeleccionada { get; set; }
        public List<SelectListItem> Salas { get; set; } 
    }
}

﻿using System;
using System.Collections.Generic;

#nullable disable

namespace tpsignalr.Modelos
{
    public partial class Sala
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public DateTime? FechaAlta { get; set; }
    }
}

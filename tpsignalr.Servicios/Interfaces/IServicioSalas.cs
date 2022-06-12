using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpsignalr.Modelos;

namespace tpsignalr.Servicios
{
    public interface IServicioSalas
    {
        public void RegistrarSala(Sala nuevaSala);
        public List<Sala> ObtenerSalas();

    }
}

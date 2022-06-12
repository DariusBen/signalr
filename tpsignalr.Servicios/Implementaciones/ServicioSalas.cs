using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpsignalr.Modelos;
using tpsignalr.Servicios.Data;
using tpsignalr.Servicios;

namespace tpsignalr.Servicios
{
    public class ServicioSalas : IServicioSalas
    {

        private readonly signalrContext _dbContext;
        private readonly ILogger<ServicioSalas> _logger;

        public ServicioSalas(signalrContext dbContext, ILogger<ServicioSalas> logger)
        {
            this._dbContext = dbContext;
            this._logger= logger;
        }


        public List<Sala> ObtenerSalas()
        {

            return this._dbContext.Salas.ToList();

        }


        public void RegistrarSala(Sala nuevaSala)
        {

            this._dbContext.Salas.Add(nuevaSala);

            this._dbContext.SaveChanges();

        }

    }
}

using API.ENTIDADES.Entidades;
using API.ENTIDADES.Modelos;
using API.NEGOCIO.Interfaces;
using API.SERVICIO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.SERVICIO.Servicios
{
    public class ServicioPelea : IServicioPelea
    {
        protected readonly INegocioPelea negocioPelea;
        public ServicioPelea(INegocioPelea negocioPelea)
        {
            this.negocioPelea = negocioPelea;
        }


        public List<PeleaModelo> Get(Guid Id)
        {
            var respuesta = new List<PeleaModelo>();
            var rPelea = negocioPelea.Get(Id);

            foreach (var pelea in rPelea)
            {
                var peleaModelo = new PeleaModelo()
                {
                    Heroe = pelea.Heroe.Nombre,
                    Villano = pelea.Villano.Nombre,
                    Mundo = pelea.Mundo.Nombre

                };
                respuesta.Add(peleaModelo);

            }
            return respuesta;
        }
    }
}

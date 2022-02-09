using API.ENTIDADES.Modelos;
using API.NEGOCIO.Interfaces;
using API.SERVICIO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace API.SERVICIO.Servicios
{
    public class ServicioPoder : IServicioPoder
    {
        protected readonly INegocioPoder negocioPoder;
        public ServicioPoder(INegocioPoder negocioPoder)
        {
            this.negocioPoder = negocioPoder;
        }

 

        public List<PoderModelo> Get(Guid Id)
        {
            var respuesta = new List<PoderModelo>();
            var rPoder = negocioPoder.Get(Id);
            foreach (var poder in rPoder)
            {
                var peleaModelo = new PoderModelo()
                {
                    Poder = poder.Nombre,
                    Heroe = poder.Heroe.Nombre,
                    Villano = poder.Villano.Nombre
                    
                };

                respuesta.Add(peleaModelo);
               respuesta.RemoveAll(peleaModelo => peleaModelo.Villano == null  || peleaModelo.Villano == null);
      
            }
            //foreach (var item in respuesta)
            //{
            //    respuesta.Where(i => i.Heroe == null).ToList().Remove();
            //}
            return respuesta;
        }
    }
}

using API.ENTIDADES.Entidades;
using API.NEGOCIO.Interfaces;
using API.SERVICIO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.SERVICIO.Servicios
{
    public class ServicioHeroe : IServicioHeroe
    {
        protected readonly INegocioHeroe negocioHeroe;
        public ServicioHeroe(INegocioHeroe negocioHeroe)
        {
            this.negocioHeroe = negocioHeroe;
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Heroe> Get()
        {
            throw new NotImplementedException();
        }

        public Heroe Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Post(Heroe entidad)
        {
            throw new NotImplementedException();
        }

        public void Put(Heroe entidad)
        {
            throw new NotImplementedException();
        }
    }
}

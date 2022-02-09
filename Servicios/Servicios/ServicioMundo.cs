using API.ENTIDADES.Entidades;
using API.NEGOCIO.Negocios;
using API.SERVICIO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.SERVICIO.Servicios
{
    public class ServicioMundo : IServicioMundo
    {
        protected readonly NegocioMundo negocioMundo;

        public ServicioMundo(NegocioMundo negocioMundo)
        {
            this.negocioMundo = negocioMundo;
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Mundo> Get()
        {
            throw new NotImplementedException();
        }

        public Mundo Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Post(Mundo entidad)
        {
            throw new NotImplementedException();
        }

        public void Put(Mundo entidad)
        {
            throw new NotImplementedException();
        }
    }
}

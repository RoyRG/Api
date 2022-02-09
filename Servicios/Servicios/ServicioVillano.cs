using API.ENTIDADES.Entidades;
using API.NEGOCIO.Interfaces;
using API.SERVICIO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.SERVICIO.Servicios
{
    public class ServicioVillano : IServicioVillano
    {
        protected readonly INegocioVillano negocioVillano;
        public ServicioVillano(INegocioVillano negocioVillano)
        {
            this.negocioVillano = negocioVillano;
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Villano> Get()
        {
            throw new NotImplementedException();
        }

        public Villano Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Post(Villano entidad)
        {
            throw new NotImplementedException();
        }

        public void Put(Villano entidad)
        {
            throw new NotImplementedException();
        }
    }
}

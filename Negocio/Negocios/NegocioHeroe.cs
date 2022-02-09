using API.ENTIDADES.Entidades;
using API.NEGOCIO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.NEGOCIO.Negocios
{
    public class NegocioHeroe : INegocioHeroe
    {
        //private readonly INegocioHeroe negocioHeroe;
        //public NegocioHeroe(INegocioHeroe negocioHeroe)
        //{
        //    this.negocioHeroe = negocioHeroe;
        //}

        public void Delete(Guid Id)
        {
            
        }

        public List<Heroe> Get()
        {
            throw new NotImplementedException();
        }

        public Heroe GetT(Guid Id)
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

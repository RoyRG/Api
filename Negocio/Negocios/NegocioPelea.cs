using API.ENTIDADES.Entidades;
using API.NEGOCIO.Interfaces;
using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace API.NEGOCIO.Negocios
{
    public class NegocioPelea : INegocioPelea
    {
        protected readonly Contexto db;
        public NegocioPelea(Contexto db)
        {
            this.db = db;
        }


        public List<Peleas> Get(Guid Id)
        {
            try
            {
                var rPeleas = db.Batalla.Include(i => i.Heroe).Include(i => i.Villano).Include(i => i.Mundo)
                    .Select(s => new Peleas { Id_Batalla = s.Id_Batalla, Heroe = new Heroe() { Nombre = s.Heroe.Nombre }, Villano = new Villano { Nombre = s.Villano.Nombre }, Mundo = new Mundo { Nombre = s.Mundo.Nombre } }).ToList();
                return rPeleas;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}

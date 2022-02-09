using API.ENTIDADES.Entidades;
using API.NEGOCIO.Interfaces;
using Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace API.NEGOCIO.Negocios
{
    public class NegocioPoder : INegocioPoder
    {
        protected readonly  Contexto db;
        public NegocioPoder(Contexto db)
        {
            this.db = db;
        }

        public List<Poderes> Get(Guid Id)
        {
            var rPoderes = db.Poderes.Where(i => i.Id_Poder == Id && i.Activo == true)
                .Include(i => i.Heroe).Include(i => i.Villano)
                .Select(s => new Poderes { Id_Poder = s.Id_Poder, Nombre = s.Nombre, Heroe = new Heroe() { Nombre = s.Heroe.Nombre }, Villano = new Villano() { Nombre = s.Villano.Nombre } }).ToList();
            return rPoderes;

        }
    }
}

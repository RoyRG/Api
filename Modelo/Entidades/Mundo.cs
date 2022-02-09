using System;
using System.Collections.Generic;
using System.Text;

namespace API.ENTIDADES.Entidades
{
    public class Mundo
    {
        public Guid Id_Mundo { get; set; }
        public string Nombre { get; set; }
        public string Galaxia { get; set; }
        public string Universo { get; set; }
        public string Actualizacion { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Fecha_Actualizacion { get; set; }
        public bool Activo { get; set; }
    }
}

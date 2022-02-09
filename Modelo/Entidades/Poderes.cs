using System;
using System.Collections.Generic;
using System.Text;

namespace API.ENTIDADES.Entidades
{
    public class Poderes
    {
        public Guid Id_Poder { get; set; }
        public Guid? Id_Heroes { get; set; }
        public Guid? Id_Villanos { get; set; }
        public string Nombre { get; set; }
        public Heroe Heroe { get; set; }
        public Villano Villano { get; set; }
        public string Actualizacion { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Fecha_Actualizacion { get; set; }
        public bool Activo { get; set; }
    }
}

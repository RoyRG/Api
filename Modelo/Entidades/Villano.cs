using System;
using System.Collections.Generic;
using System.Text;

namespace API.ENTIDADES.Entidades
{
    public class Villano
    {
        public Guid Id_Villanos { get; set; }
        public string Nombre { get; set; }
        public string Actualizacion { get; set; }
        public DateTime? Fecha{ get; set; }
        public DateTime? Fecha_Actualizacion { get; set; }
        public bool Activo { get; set; }

    }
}

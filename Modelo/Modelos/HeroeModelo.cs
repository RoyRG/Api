using System;
using System.Collections.Generic;
using System.Text;

namespace API.ENTIDADES.Modelos
{
    public class HeroeModelo
    {
        public string Nombre { get; set; }
        public string Actualizacion_Heroe { get; set; }
        public DateTime? Fecha_Heroe { get; set; }
        public DateTime? Fecha_Actualizacion_Heroe { get; set; }
        public bool Activo { get; set; }

    }
}

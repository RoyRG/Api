using System;
using System.Collections.Generic;
using System.Text;

namespace API.ENTIDADES.Modelos
{
    public class VillanoModelo
    {
        public string Nombre { get; set; }
        public string Actualizacion_Villano { get; set; }
        public DateTime? Fecha_Villano { get; set; }
        public DateTime? Fecha_Actualizacion_Villano { get; set; }
        public bool Activo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace API.ENTIDADES.Entidades
{
    public class Peleas
    {
        public Guid Id_Batalla { get; set; }
        public Guid Id_Heroes { get; set; }
        public Guid Id_Villanos { get; set; }
        public Guid Id_Mundo { get; set; }
        public Heroe Heroe { get; set; }
        public Villano Villano { get; set; }
        public Mundo Mundo { get; set; }
    }
}

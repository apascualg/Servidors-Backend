using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoInicial
{
    public class Castillo
    {
        public int CastilloID { get; set; }
        public string nombre { get; set; }
        public double metroscuadrados { get; set; }
        public virtual ICollection <Goomba> Goombas { get; set; }
    }
}

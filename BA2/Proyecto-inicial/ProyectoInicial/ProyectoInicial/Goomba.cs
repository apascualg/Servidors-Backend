using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoInicial
{
    public class Goomba
    {
        public int GombaID { get; set; }
        public string nombre { get; set; }
        public float altura { get; set; }
        public virtual Castillo Castillo { get; set; }
    }
}

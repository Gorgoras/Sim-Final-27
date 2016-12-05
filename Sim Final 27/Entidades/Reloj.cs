using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim_Final_27.Entidades
{
    class Reloj
    {
        public int id { get; set; }
        public string estado { get; set; }
        public double tiempoEntrada { get; set; }
        public double tiempoComienzoControl { get; set; }
        public double tiempoFinControl { get; set; }
        public Reloj(int id, double tiempoLlegada) {
            this.id = id;
            tiempoEntrada = tiempoLlegada;
            estado = "En cola";
        }
    }
}

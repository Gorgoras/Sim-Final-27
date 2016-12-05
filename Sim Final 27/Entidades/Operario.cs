using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim_Final_27.Entidades
{
    class Operario
    {
        public int id { get; set; }
        public string estado { get; set; }
        public double tiempoFinAtencion { get; set; }
        public Reloj relojAtendiendo { get; set; }
        public double tiempoOcupado{ get; set; }
        public Operario(int id) {
            this.id = id;
            tiempoOcupado = 0;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim_Final_27.Generadores
{
    class randomGenerator
    {
    
        public static double generarRandom()
        {
            Random rnd = new Random();
            rnd.NextDouble();
            rnd.NextDouble();
            rnd.NextDouble();
            double ret = rnd.NextDouble();
            return ret;
        }

        public static double generarTiempoExponencial(double rnd)
        {
            double tiempo = -(0.01) * Math.Log(1-rnd);
            return tiempo;
        }

        public static double generarTiempoDistNormal (double rnd1, double rnd2)
        {
            double z = Math.Sqrt(-2 * Math.Log(rnd1)) * Math.Cos(2 * Math.PI * rnd2);
            double tiempo = 0.08 + 0.01 * z;
            return tiempo;
        }

    }
}

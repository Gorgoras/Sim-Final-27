using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim_Final_27.Generadores
{
    class randomGenerator
    {
        static int seed = 1;
        public static double generarRandom()
        {
            Random rnd = new Random(seed);
            seed++;
            rnd.NextDouble();
            rnd.NextDouble();
            rnd.NextDouble();
            double ret = rnd.NextDouble();
            return ret;
        }

        public static double generarTiempoExponencial(double rnd, double mediaExp)
        {
            double tiempo = -(mediaExp) * Math.Log(1-rnd);
            return tiempo;
        }

        public static double generarTiempoDistNormal (double rnd1, double rnd2, double mediaNormal, double desvEstNormal)
        {
            double z = Math.Sqrt(-2 * Math.Log(rnd1)) * Math.Cos(2 * Math.PI * rnd2);
            double tiempo = mediaNormal + desvEstNormal * z;
            return tiempo;
        }

    }
}

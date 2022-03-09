using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista05_POO_Basica.ConsoleApp.Numero5
{
    public class Esfera
    {
        double raioEsfera;
        const double pi = 3.14;

        public double CalcularRaioEsfera()
        {
            double volumeFinal = (4 * (pi * (raioEsfera * raioEsfera * raioEsfera))) / 3;

            return volumeFinal;
        }

    }
}

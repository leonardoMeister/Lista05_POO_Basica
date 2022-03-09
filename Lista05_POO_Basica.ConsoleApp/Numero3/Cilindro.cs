using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista05_POO_Basica.ConsoleApp.Numero3
{
    public  class Cilindro
    {
        double raio;
        double altura;
        const double pi = 3.14;

        public double CalcularVolumeCilindro()
        {
            double resultado = pi * ((raio * raio) * altura);
            return resultado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista05_POO_Basica.ConsoleApp.Numero8
{
    public  class LataOleo
    {
        double raio;
        double altura;
        const double pi = 3.14;

        public double CalcularVolumeLata()
        {
            double resultado = pi * ((raio * raio) * altura);
            return resultado;
        }
    } 
}

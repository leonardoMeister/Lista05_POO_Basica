using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista05_POO_Basica.ConsoleApp.Numero2
{
    public class ConversorTemperatura2
    {
        double temperaturaFahrenheit;
        double temperaturaCelcius;

        public double ConverterParaCelcius()
        {
            double resultado = (temperaturaFahrenheit - 32) * (5 / 9);

            return resultado;
        }
        public double ConverterParaFahrenheit()
        {
            double resultado = (temperaturaCelcius * (9 / 5)) + 32;

            return resultado;
        }
    }
}

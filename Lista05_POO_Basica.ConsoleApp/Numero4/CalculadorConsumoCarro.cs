using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista05_POO_Basica.ConsoleApp.Numero4
{
    public class CalculadorConsumoCarro
    {
        double kmInicial;
        double kmFinal;
        double consumoTotalPercurso;

        public double CalcularConsumoCombustivelPorKM()
        {
            double distanticaTotal = kmFinal - kmInicial;
            
            double resultado = consumoTotalPercurso / distanticaTotal;

            return resultado;
        }

    }
}

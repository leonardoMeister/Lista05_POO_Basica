using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista05_POO_Basica.ConsoleApp.Numero7
{
    public class Salario
    {
        double salarioBase;
        double ValorTotalVendas;
        double percentualComissao;

        public double CalcularSalarioTotal()
        {
            double salarioFinal = salarioBase + (ValorTotalVendas * percentualComissao);

            return salarioFinal;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista05_POO_Basica.ConsoleApp.Numero1
{
    public  class Caixa
    {
        double baseCaixa ;
        double alturaCaixa;
        double comprimentoCaixa;

        public double ObterVolumeCaixa()
        {
            double volume = baseCaixa * alturaCaixa * comprimentoCaixa;
            return volume;
        }

    }
}

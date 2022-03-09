using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista05_POO_Basica.ConsoleApp.Numero9._1
{
    public class MediaPonderada
    {
        List<double> listaNota;
        List<double> listaPeso;

        public double CalcularMediaPonderada()
        {
            double resultado;

            double somaPesos = 0;
            double somaNotaMultiplicadoPeloPeso = 0;

            for (int i = 0; i < listaPeso.Count; i++) somaPesos += listaPeso[i];
            for (int i = 0; i < listaNota.Count; i++) somaNotaMultiplicadoPeloPeso += listaNota[i] * listaPeso[i];
            resultado = somaNotaMultiplicadoPeloPeso / somaPesos;

            return resultado;
        }
    }
}

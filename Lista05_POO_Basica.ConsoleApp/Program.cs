using Lista05_POO_Basica.ConsoleApp.Numero9;
using System;
using System.Collections.Generic;

namespace Lista05_POO_Basica.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MediaHarmonica me = new MediaHarmonica();

            List<double> notas = new List<double>();
            notas.Add(12);
            notas.Add(6);
            notas.Add(8);
            notas.Add(14);


            me.listaNotas = notas;

            me.CalcularMediaHarmonica();




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista05_POO_Basica.ConsoleApp.Numero9
{
    public class MediaHarmonica
    {
        public List<double> listaNotas;

        public double CalcularMediaHarmonica()
        {
            double resultado = 0;

            int numeroNotas = listaNotas.Count;

            double mmc = MinimoMultiploComum();

            return resultado;
        }

        public double MinimoMultiploComum()
        {
            List<int> valoresSalvos = new List<int>();
            List<double> novaLista = listaNotas;

            PegarValoresParaMultiplicar(valoresSalvos, novaLista);

            double mmc = MultiplicaValores(valoresSalvos);

            return mmc;
        }

        private double MultiplicaValores(List<int> valoresSalvos)
        {
            double somatoria = valoresSalvos[0];
            for (int i = 1; i < valoresSalvos.Count; i++)
            {
                somatoria = somatoria * valoresSalvos[i];
            }
            return somatoria;
        }

        private static void PegarValoresParaMultiplicar(List<int> valoresSalvos, List<double> novaLista)
        {
            int x = 2;
            while (true)
            {
                bool existeValorDivisivelPorX = false;

                for (int i = 0; i < novaLista.Count; i++)
                {
                    if (novaLista[i] == 1) novaLista.Remove(novaLista[i]);
                    if (novaLista.Count == 0) return;
                }

                for (int i = 0; i < novaLista.Count; i++)
                {
                    if (novaLista[i] % x == 0)
                    {
                        valoresSalvos.Add(x);
                        existeValorDivisivelPorX = true;
                        break;
                    }
                }
                if (existeValorDivisivelPorX)
                {
                    for (int i = 0; i < novaLista.Count; i++)
                    {
                        if (novaLista[i] % x == 0)
                        {
                            novaLista[i] = novaLista[i] / x;
                        }
                    }
                }

                if (existeValorDivisivelPorX) continue;
                x++;
            }
        }
    }
}

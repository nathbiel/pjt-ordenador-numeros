using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjt_ordenador_numeros
{
    internal class cls_ordenarNumeros
    {
        public List<int> Numeros { get; private set; }

        public NumeroSorter(string caminhoArquivo)
        {
            Numeros = new List<int>();

            if (File.Exists(caminhoArquivo))
            {
                foreach (var linha in File.ReadAllLines(caminhoArquivo))
                {
                    if (int.TryParse(linha, out int numero))
                    {
                        Numeros.Add(numero);
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("Arquivo não encontrado.");
            }
        }

        public void Ordenar()
        {
            int n = Numeros.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (Numeros[j] > Numeros[j + 1])
                    {
                        // Troca os números de posição
                        int temp = Numeros[j];
                        Numeros[j] = Numeros[j + 1];
                        Numeros[j + 1] = temp;
                    }
                }
            }
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, Numeros);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarEntrada
{
    internal class ValidaZeroUm
    {
        public void ValidaEntradaZeroUmTexto() {

            while (true)
            {
                Console.Write("Digite entrada 0 ou 1: ");
                string entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.WriteLine("Entrada vazia!\n");
                    continue;

                }
                else if (entrada.Trim() != "0" && entrada.Trim() != "1")
                {
                    Console.WriteLine("Entrada inválida! Digite 0 ou 1.\n");
                    continue;
                }
                else
                {
                    Console.WriteLine("\nEntrada válida: " + entrada);
                    return;
                }
            }
        }

        public void ValidaEntradaZeroUmInteiro()
        {
            while (true)
            {
                Console.Write("Digite entrada 0 ou 1: ");
                string entrada = Console.ReadLine();

                if(!int.TryParse(entrada, out int valor))
                {
                    Console.WriteLine("Entrada inválida! Digite um número inteiro.\n");
                    continue;
                } else if (valor != 0 && valor != 1)
                {
                    Console.WriteLine("Entrada inválida! Digite 0 ou 1.\n");
                    continue;
                }
                else
                {
                    Console.WriteLine("\nEntrada válida: " + valor.ToString());
                    return;
                }
            }    
        }
    }
}

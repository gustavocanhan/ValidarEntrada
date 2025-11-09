using System;
using System.Text.RegularExpressions;

namespace ValidarEntrada
{
    internal class ValidaCaractere
    {
        public void ValidaEntradaCaractere()
        {
            string padraoNumero = @"^[+-]?\d+([.,]\d+)?$";
            string padraoCaracterEspecial = @"^[^a-zA-Z0-9\s]+$";

            while (true)
            {
                Console.Write("Digite um caractere de a-z ou A-Z: ");
                string entrada = Console.ReadLine();

                if (string.IsNullOrEmpty(entrada))
                {
                    Console.WriteLine("Entrada vazia!\n");
                    continue;
                }
                else if (entrada.Length != 1)
                {
                    Console.WriteLine("Digite apenas um caractere!\n");
                    continue;
                }
                else if (Regex.IsMatch(entrada, padraoCaracterEspecial))
                {
                    Console.WriteLine("Caractere especial não é permitido!\n");
                    continue;
                }
                else if (Regex.IsMatch(entrada, padraoNumero))
                {
                    Console.WriteLine("Número não é permitido!\n");
                    continue;
                }
                else
                {
                    Console.WriteLine("\nEntrada válida: " + entrada);
                    return;
                }
            }
        }
    }
}

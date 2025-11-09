using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ValidarEntrada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValidaZeroUm validador = new ValidaZeroUm();
            ValidaCaractere validadorCaractere = new ValidaCaractere();

            int opcaoMenu = -1;

            while(opcaoMenu != 0)
            {
                Console.WriteLine("=== MENU ===");
                Console.WriteLine("1 - Validar entrada 0 e 1 como texto");
                Console.WriteLine("2 - Validar entrada 0 e 1 como inteiro");
                Console.WriteLine("3 -  Validar entrada de caractere de A-Z ou a-z");
                Console.WriteLine("0 - Sair");

                Console.Write("Escolha uma opção: ");

                if(!int.TryParse(Console.ReadLine(), out opcaoMenu))
                {
                    Console.WriteLine("Opção inválida! Digite um número inteiro.\n");
                    continue;
                }

                switch (opcaoMenu)
                {
                    case 1:
                        validador.ValidaEntradaZeroUmTexto();
                        break;
                    case 2:
                        validador.ValidaEntradaZeroUmInteiro();
                        break;
                    case 3:
                        validadorCaractere.ValidaEntradaCaractere();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!\n");
                        break;
                }

            }

            Console.WriteLine("Programa encerrado.");
        }
    }
}

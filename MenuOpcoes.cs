using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class MenuOpcoes
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escolha um opção");
            Console.WriteLine("1 - 'Olá, mundo!'");
            Console.WriteLine("2 - 'Bem-vindo ao C#'");
            Console.WriteLine("3 - 'Sair do programa'");

            Console.WriteLine("Digite um número das opções: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int opcao))
            {
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Olá, mundo!");
                        break;

                    case 2:
                        Console.WriteLine("Bem-vindo ao C#");
                        break;

                    case 3:
                        Console.WriteLine("Sair do programa");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Escolha um número entre 1, 2 e 3.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Você digitou algo inválido. Por favor, insira apenas números.");
            }
        }
    }
}

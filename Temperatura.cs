using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class Temperatura
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção para conversão:");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");

            if (int.TryParse(Console.ReadLine(), out int opcao) && (opcao == 1 || opcao == 2))
            {
                Console.WriteLine("Digite a temperatura:");

                if (double.TryParse(Console.ReadLine(), out double temperatura))
                {
                    switch (opcao)
                    {
                        case 1:
                            double fahrenheit = (temperatura * 9 / 5) + 32;
                            Console.WriteLine($"{temperatura}°C equivale a {fahrenheit:F2}°F");
                            break;

                        case 2:
                            double celsius = (temperatura - 32) * 5 / 9;
                            Console.WriteLine($"{temperatura}°F equivale a {celsius:F2}°C");
                            break;

                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Temperatura inválida! Insira um número válido.");
                }
            }
            else
            {
                Console.WriteLine("Opção inválida! Escolha 1 ou 2.");
            }
        }
    }
}

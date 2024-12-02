using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class CalculadoraFatorial
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para calcular o fatorial:");
            int numero = int.Parse(Console.ReadLine());

            // Verificar se o número é válido para o cálculo do fatorial
            switch (numero)
            {
                case < 0:
                    Console.WriteLine("Número inválido! O fatorial não é definido para números negativos.");
                    break;

                case 0:
                    Console.WriteLine("O fatorial de 0 é 1.");
                    break;

                default:
                    int fatorial = 1;
                    for (int i = 1; i <= numero; i++)
                    {
                        fatorial *= i;
                    }
                    Console.WriteLine($"O fatorial de {numero} é {fatorial}.");
                    break;
            }
        }
    }
}

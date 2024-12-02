using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class CalcularImpostos
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Forneça o seu sálario para calcular os impostos: ");

            if (decimal.TryParse(Console.ReadLine(), out decimal salario) && salario > 0)
            {
                decimal imposto;

                switch (salario)
                {
                    case <= 1500:
                        imposto = salario * 0.05m;
                        Console.WriteLine($"Salário: R${salario:F2} | Imposto: R${imposto:F2} (5%)");
                        break;

                    case <= 3000:
                        imposto = salario * 0.10m;
                        Console.WriteLine($"Salário: R${salario:F2} | Imposto: R${imposto:F2} (10%)");
                        break;

                    default:
                        imposto = salario * 0.15m;
                        Console.WriteLine($"Salário: R${salario:F2} | Imposto: R${imposto:F2} (15%)");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Valor inválido! Por favor, insira um número positivo.");
            }
        }
    }
}

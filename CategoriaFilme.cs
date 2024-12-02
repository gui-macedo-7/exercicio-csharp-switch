using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class CategoriaFilme
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a classificação etária do filme (G, PG, PG-13, R):");

            string classificacao = Console.ReadLine()?.ToUpper();

            switch (classificacao)
            {
                case "G":
                    Console.WriteLine("Classificação: Livre para todos os públicos.");
                    break;

                case "PG":
                    Console.WriteLine("Classificação: Permitido para maiores de 10 anos.");
                    break;

                case "PG-13":
                    Console.WriteLine("Classificação: Permitido para maiores de 13 anos.");
                    break;

                case "R":
                    Console.WriteLine("Classificação: Permitido para maiores de 18 anos.");
                    break;

                default:
                    Console.WriteLine("Classificação inválida! Digite uma das opções válida: G, PG, PG-13 ou R.");
                    break;
            }
        }
    }
}

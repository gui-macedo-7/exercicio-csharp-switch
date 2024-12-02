using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class ClassIdade
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a idade:");
            int idade = int.Parse(Console.ReadLine());

            switch (idade)
            {
                case <= 12:
                    Console.WriteLine("Criança");
                    break;

                case <= 17:
                    Console.WriteLine("Adolescente");
                    break;

                case <= 59:
                    Console.WriteLine("Adulto");
                    break;

                case >= 60:
                    Console.WriteLine("Idoso");
                    break;

                default:
                    Console.WriteLine("Idade inválida");
                    break;
            }
        }
    }
}



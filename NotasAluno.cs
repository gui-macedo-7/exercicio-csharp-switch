using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class NotasAluno
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Insira a nota que você tirou: (O número tem que ser inteiro)");

            if (int.TryParse(Console.ReadLine(), out int nota) && nota >= 0 && nota <= 10)
            {

                switch (nota)
                {
                    case <= 2:
                        Console.WriteLine("Sua nota é F! Precisa melhorar.");
                        break;

                    case <= 4:
                        Console.WriteLine("Sua nota é D! Precisa melhorar.");
                        break;

                    case <= 6:
                        Console.WriteLine("Sua nota é C! Precisa melhorar.");
                        break;

                    case <= 8:
                        Console.WriteLine("Sua nota é de B! Parabéns.");
                        break;

                    case >= 9:
                        Console.WriteLine("Sua nota é A! Parabéns.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Digite um nota de 0 a 10.");
            }
        }
    }
}

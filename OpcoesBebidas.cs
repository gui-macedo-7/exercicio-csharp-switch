using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class OpcoesBebidas
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Escolha umas das bebidas");
            Console.WriteLine("Café");
            Console.WriteLine("Chá");
            Console.WriteLine("Suco");
            Console.WriteLine("Refrigerante");

            Console.WriteLine("Insira o nome da uma das bebidas (digite como está nas opções)");
            string bebida = Console.ReadLine();

            switch (bebida)
            {
                case "Café":
                    Console.WriteLine("Escolhido Café!");
                    break;

                case "Chá":
                    Console.WriteLine("Escolhido Chá!");
                    break;
                
                case "Suco":
                    Console.WriteLine("Escolhido Suco!");
                    break;

                case "Refrigerante":
                    Console.WriteLine("Escolhido Refrigerante!");
                    break;

                default:
                    Console.WriteLine("Bebida não reconhecida (Certifique-se que o nome digitado é igual o das opções!)");
                    break;
            }
        }
    }
}

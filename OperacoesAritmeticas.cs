using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class OperacoesAritmeticas
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Digite um número: ");
            double numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            double numero2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um operador (+, -, *, /)");
            char operador = Console.ReadLine()[0];

            double resultado;
            switch (operador)
            {
                case '+':
                    resultado = numero1 + numero2;
                    Console.WriteLine($" {numero1} + {numero2} = {resultado}");
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    Console.WriteLine($" {numero1} - {numero2} = {resultado}");
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    Console.WriteLine($" {numero1} x {numero2} = {resultado}");
                    break;
                case '/':
                    resultado = numero1 / numero2;
                    Console.WriteLine($" {numero1} / {numero2} = {resultado}");
                    break;
            }
        }
    }
}

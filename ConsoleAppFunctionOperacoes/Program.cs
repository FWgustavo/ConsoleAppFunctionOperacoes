using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFunctionOperacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a operação(+,-,/,*): ");
            string op = Console.ReadLine();


            operacao(n1 , n2, op);

            Console.ReadKey();
        }

        static void operacao(double n1, double n2, string op) 
        {
            double resultado;
            switch (op)
            {
                case "+": 
                    resultado = n1 + n2;

                    Console.WriteLine("O resultado da sua soma é: "+resultado);

                break;


                case "-":

                    resultado = n1 - n2;

                    Console.WriteLine("O resultado da subtração é: " + resultado);

                break;


                case "*":

                    resultado = n1 * n2;

                    Console.WriteLine("O resultado da multiplicação é: " + resultado);

                break;


                case "/":

                    resultado = n1 / n2;

                    Console.WriteLine("O resultado da divisão é: " + resultado);

                break;


                default:
                    
                    Console.WriteLine("Operação inserida inválida ");

                break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá mundo!");

            int idade = 20;
            idade += 5;
            Console.WriteLine(idade);

            double numero = 2.0;
            Console.WriteLine(numero);

            if (numero > 1.0)
            {
                Console.WriteLine("oi");
            }
            else if (numero > 0.5)
            {
                Console.WriteLine("oi2");
            }
            else
            {
                Console.WriteLine("oi3");
            }

            Console.WriteLine("Precione enter para continuar. . .");
            Console.ReadLine();
        }
    }
}

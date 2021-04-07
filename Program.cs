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

            bool condicao = true;
            bool condicao2 = false;
            bool verdade = true;
            string mensagem;

            if (verdade == true)
            {
                mensagem = "nova mensagem";
                Console.WriteLine(mensagem);
            }

            if (numero > 1.0 && condicao)
            {
                Console.WriteLine("oi");
            }
            else if (numero > 0.5 || condicao2)
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

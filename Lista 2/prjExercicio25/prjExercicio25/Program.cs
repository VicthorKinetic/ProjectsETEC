using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variavel (n,r)
            //n = 0
            //solicitar n
            //receber n
            //r = n%2
            //se r = 0
              //exibir par
            //se não
              //exibir impar





            int n, r;
            n = 0; r = 0;

            Console.Write("Digite um número, verificaremos se ele é par ou impar: ");
            n = int.Parse(Console.ReadLine());

            r = n % 2;

            if (r == 0)
            {
                Console.Write("O número é par");
            }

            else
            {
                Console.Write("O número é impar");
            }

            Console.ReadKey();






        }
    }
}

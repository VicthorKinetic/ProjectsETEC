using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio28
{
    class Program
    {
        static void Main(string[] args)
        {

            //declarar variaveis(N1,N2)
            //N1 = 0; N2 = 0;
            //solicitar N1
            //receber N1
            //repetir
              //solicitar N2
              //receber N2
            //enquanto (N2 <= N1)


            int n1 = 0, n2 = 0;

            Console.Write("Digite o 1° número: ");
            n1 = int.Parse(Console.ReadLine());

            do
            {
                Console.Clear();

                Console.Write("Digite o 2° número: ");
                n2 = int.Parse(Console.ReadLine());
            }
            while (n2 <= n1);

            Console.Write("FOI");

            Console.ReadKey();
        }
    }
}

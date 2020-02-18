using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis (A,r)
            //A = 0; r = 0;
            //solicitar r
            //receber r
            //A = 3.14159 * (r * r);
            //exibir A

            double A, r;
            A = 0; r = 0;

            Console.Write("Insira o raio da circunferência: ");
            r = double.Parse(Console.ReadLine());

            A = 3.14159 * (r * r);

            Console.Write("A area da circunferência é igual a: " + A.ToString());
            Console.ReadKey();


        }
    }
}

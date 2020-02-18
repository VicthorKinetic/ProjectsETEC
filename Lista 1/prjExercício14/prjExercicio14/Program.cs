using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            double vl;
            double vc;
            double ve;
            double a;
            double r;

            vl = 1; vc = 1; ve = 1; a = 1; r = 1;

            Console.Write("Digite o raio da esfera: ");
            r = double.Parse(Console.ReadLine());
            Console.Write("Digite a aresta do cubo: ");
            a = double.Parse(Console.ReadLine());

            vc = a * a * a;
            ve = (4 * 3.14 * r * r * r) / 3;
            vl = vc - ve;

            Console.Write("O volume livre é: " + vl.ToString());
            Console.ReadKey();

        }
    }
}

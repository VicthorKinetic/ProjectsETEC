using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double vf;
            double a;
            double vi;
            double t;

            vf = 1; a = 1; vi = 1; t = 1;

            Console.Write("Digite a velocidade inicial: ");
            vi = double.Parse(Console.ReadLine());

            Console.Write("Insira a aceleração: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o tempo: ");
            t = double.Parse(Console.ReadLine());
            vf = vi + (a * t);
            vf = vf * 3.6;

            Console.Write("A velocidade final é igual a: " + vf.ToString());
            Console.ReadKey();



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double se;
            double co;
            double tg;
            double sec;

            a = 1; se = 1; co = 1; tg = 1; sec = 1;

            Console.Write("Digite o ângulo solicitado: ");
            a = double.Parse(Console.ReadLine());

            a=(a*3.14)/180;

            se = Math.Sin(a);
            co = Math.Cos(a);
            tg = Math.Tan(a);
            sec = 1 / co;

            Console.WriteLine("Os resultados serão: ");
            Console.ReadKey();
            Console.WriteLine("Seno = " + se.ToString());
            Console.ReadKey();
            Console.WriteLine("Coseno = " + co.ToString());
            Console.ReadKey();
            Console.WriteLine("Tangente = " + tg.ToString());
            Console.ReadKey();
            Console.WriteLine("Secante = " + sec.ToString());
            Console.ReadKey();


           
        }
    }
}

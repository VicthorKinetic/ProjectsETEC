using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio40
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            int n=0;int ma=0;int s=0;int c = 0;
            double me = 0;
            do
            {
                Console.Write("Digite um número: 0");
                n = int.Parse(Console.ReadLine());
                s = s + n;

                if (ma < n)
                {
                    ma = n;
                }

                else
                {}
                c = c + 1;
            }
            while (c <= 10);
            me = s / 10;
            Console.Write("Maior: " + ma.ToString() + "Soma: " + s.ToString() + "Média: " + me.ToString());

            Console.ReadKey();

        }
    }
}

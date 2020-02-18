using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            int[] x = new int[20];
            int[] z = new int[20];
            int mano = 0;
            int mina = 1;
            int y = 0;
            do
            {

                Console.Write("Digite o " + mina + "° numero: ");
                x[mano] = int.Parse(Console.ReadLine());

                mina = mina + 1;
                mano = mano + 1;

            }
            while (mano <= 19);

            Console.Write("Digite um numero para ser o multiplicador: ");
            y = int.Parse(Console.ReadLine());

            mano = 0;
            do
            {

                z[mano] = x[mano] * y;
                Console.WriteLine(z[mano]);
                mano = mano + 1;
            }
            while (mano != 20);

            Console.ReadKey();
        }
    }
}

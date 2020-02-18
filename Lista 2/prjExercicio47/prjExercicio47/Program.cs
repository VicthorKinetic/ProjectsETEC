using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();

            int mano;
            mano = 0;
            int [] x = new int [10];

            do
            {

                Console.Write("Digita um numero ai: ");
                x[mano] = int.Parse(Console.ReadLine());

                mano = mano + 1;

            }
            while (mano <= 9);

            Console.WriteLine(" ");

            do
            {
                mano = mano - 1;
            Console.WriteLine(x[mano]);
                
            }
            while(mano!=0);

            Console.ReadKey();
        }
    }
}

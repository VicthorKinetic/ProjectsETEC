using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio48
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
            int[] x = new int[10];
            int s = 0;
            do
            {

                Console.Write("Digita um numero ai: ");
                x[mano] = int.Parse(Console.ReadLine());

                mano = mano + 1;

            }
            while (mano <= 9);

            Console.WriteLine(" ");

            if (x[0] > x[1])
            {
                x[0] = s;
            }
            else
            {
                x[1] = s;
            }

            if (s < x[2])
            {
                s = x[2];
            }
           
            if (s < x[3])
            {
                s = x[3];
            }
            
            if (s < x[4])
            {
                s = x[4];
            }
            
            if (s < x[5])
            {
                s = x[5];
            }
            
            if (s < x[6])
            {
                s = x[6];
            }

            if (s < x[7])
            {
                s = x[7];
            }
            
            if (s < x[8])
            {
                 s = x[8] ;
            }

            if (s < x[9])
            {
                s = x[9];
            }

            Console.Write("O maior número é: " + s.ToString());

            Console.ReadKey();
            
            
            
            
         }
    }
}

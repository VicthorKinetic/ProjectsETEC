using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicico57
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] x = new int[20];
            int y = -1, z = 0, a = 1,o=0,j=0;

            do
            {
            y = y + 1;
                o=o+1;

            Console.WriteLine("Digite o "+o+"° valor");
            x[y] = int.Parse(Console.ReadLine());
            }
            while(o!=20);

            y = -1;
            z = 0;

            do
            {
                do
                {
                    z = z + 1;
                    y = y + 1;
                    if (x[y] > x[z])
                    {
                        a = x[y];
                        x[y] = x[z];
                        x[z] = a;
                    }
                }
                while (z != 19);
                y = -1;
                z = 0;
                j = j + 1;

            }
            while (j != 20);

            y = -1;

            do
            {
                y = y + 1;
            Console.WriteLine(x[y]);
            }
            while(y!=19);

            Console.ReadKey();

        }
    }
}

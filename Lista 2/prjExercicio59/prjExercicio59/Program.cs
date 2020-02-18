using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio59
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = new string[20];
            int t = 1;
            string a = " ";
            int g = 0;
            int cont = -1;
            int y = 0;
            int h = 0;
            int l = 0;

            do
            {
                cont = cont + 1;
                Console.Write("Digite um nome: ");
                n[cont] = Console.ReadLine();
               

            }
            while (cont != 19);

            do
            {
                cont = 0;
                y = 0;
                h = 0;
                t = 0;
                do
                {
                    if (n[cont][y] > n[t][y])
                    {
                        a = n[cont];
                        n[cont] = n[t];
                        n[t] = a;
                        cont = cont + 1;
                        t = t + 1;
                        h = h + 1;
                    }

                    else
                    {
                        do
                        {
                            if (n[cont][y] == n[t][y])
                            {
                                h = h + 1;
                                if (n[cont][y] > n[t][y])
                                {
                                    a = n[cont];
                                    n[cont] = n[t];
                                    n[t] = a;
                                    cont = cont + 1;
                                    t = t + 1;
                                    h = h + 1;
                                }
                            }
                        }
                        while (h != 19);
                    }

                    if (cont == 19)
                    {
                        g = g + 1;
                    }

                }
                while (g != 30);

                l = l + 1;

            }
            while (l != 20);
        
            h = -1;
            do
            {
                h = h + 1;
                Console.WriteLine(n[h]);
            }
            while (h != 19);
            Console.ReadKey();
}
}
}
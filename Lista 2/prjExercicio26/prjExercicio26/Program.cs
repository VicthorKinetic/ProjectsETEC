using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis(n1,n2,n3)
            //n1 = 0; n2 = 0; n3 = 0;
            //solicitar n1
            //receber n1
            //solicitar n2
            //receber n2
            //solicitar n3
            //receber n3
            //se n1 > n2
              //se n1 > n3
                //se n2 > n3
                  //exibir n1 + n2 + n3
                //se não
                  //exibir n1 + n3 + n2
              //se não
                //exibir n3+ n1 + n2
            //se não
              //se n2 > n3
                //se n1 > n3
                  //exibir 
                //se não
              //se não


            int n1, n2, n3;
            n1 = 0; n2 = 0; n3 = 0;

            Console.Write("Insira o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Insira o segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Insira o terceiro número: ");
            n3 = int.Parse(Console.ReadLine());

            if (n1 < n2)
            {
                if (n1 < n3)
                {
                    if (n2 < n3)
                    {
                        Console.Write("A ordem será " + n3 + " " + n2 + " " + n1 + " .");
                    }

                    else
                    {
                        Console.Write("A ordem será " + n2 + " " + n3 + " " + n1 + " .");
                    }
                }

                else
                {
                    Console.Write("A ordem será " + n2 + " " + n1 + " " + n3 + " .");
                }
            }

            else
            {
                if (n2 < n3)
                {
                    if (n1 < n3)
                    {
                        Console.Write("A ordem será " + n3 + " " + n1 + " " + n2 + " .");
                    }

                    else
                    {
                        Console.Write("A ordem será " + n1 + " " + n3 + " " + n2 + " .");
                    }
                }

                else
                {
                    if (n1 < n2)
                    {
                        Console.Write("A ordem será " + n2 + " " + n1 + " " + n3 + " .");
                    }

                    else
                    {
                        Console.Write("A ordem será " + n1 + " " + n2 + " " + n3 + " .");
                    }
                  
                }
            }

            Console.ReadKey();


        }
    }
}

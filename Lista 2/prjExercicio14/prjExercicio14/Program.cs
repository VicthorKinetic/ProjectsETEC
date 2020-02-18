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
            //declarar variaveis ( n1,n2)
            //n1 = 0; n2 = 0;
            //solicitar n1
            //receber n1
            //solicitar n2
            //receber n2
            //se n1 > n2
             //exibir n1
            //se não
             //se n1 = n2
              //exibir "Os números são identicos"
             //se não
              // exibir n2

            int n1, n2;
            n1 = 0; n2 = 0;

            Console.Write("Digite um número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.Write("O maior número é o primeiro inserido, ou seja: " + n1.ToString());
                Console.ReadKey();
            }

            else
            {
                if (n1 < n2)
                {
                    Console.Write("O maior número é o segundo inserido, ou seja: " + n2.ToString());
                }

                else
                {

                    Console.Write("Os números são idênticos");
                }

                Console.ReadKey();



            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis(l1,l2,l3)
            //l1 = 1; l2 = 1; l3 = 1;
            //solicitar l1
            //receber l1
            //solicitar l2
            //receber l2
            //solicitar l3
            //receber l3
            //l1 = l1*l1
            //l2 = l2*l2
            //l3 = l3*l3
              //se l1 = l2 + l3 
                //se l2 = l1 + l3
                  //se l3 = l1 + l2
                    //exibir triângulo retângulo
                  //se não
                    //exibir não triângulo retângulo
                //se não
                  //exibir não triângulo retângulo
              //se não
                //exibir não triângulo retângulo

            int l1, l2, l3;
            l1 = 1; l2 = 1; l3 = 1;

            Console.Write("Solicitamos um lado: ");
            l1 = int.Parse(Console.ReadLine());
            Console.Write("Solicitamos outro lado: ");
            l2 = int.Parse(Console.ReadLine());
            Console.Write("Solicitamos o último lado: ");
            l3 = int.Parse(Console.ReadLine());

            l1 = l1*l1;
            l2 = l2*l2;
            l3 = l3*l3;

            if (l1 == l2 + l3)
            {

                if (l2 == l1 + l3)
                {

                    if (l3 == l1 + l3)
                    {
                        Console.Write("Com estas medidas é possível construir um triângulo retângulo!");
                    }

                    else
                    {
                        Console.Write("Com estas medidas não é possível formar um triângulo retângulo.");
                    }
                }

                else
                {
                    Console.Write("Com estas medidas não é possível formar um triângulo retângulo.");
                }
                 
            }

            else
            {
                Console.Write("Com estas medidas não é possível formar um triângulo retângulo.");
            }


            Console.ReadKey();

        }
    }
}

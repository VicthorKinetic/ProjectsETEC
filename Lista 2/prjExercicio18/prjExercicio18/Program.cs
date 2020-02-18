using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis (p,h,P)
            //p = 1; h = 1; P = 0;
            //solicitar p
            //receber p
            //solicitar h
            //receber h
            //P = p/(h*h)
            //se p < 20
              //exibir abaixo do peso
            //se não
              //se p >= 25
                //exibir acima do peso
              //se não
                //exibir peso ideal

            double p, h, P;
            p = 1; h = 1; P = 0;

            Console.Write("Digite seu peso: ");
            p = double.Parse(Console.ReadLine());
            Console.Write("Digite sua altura: ");
            h = double.Parse(Console.ReadLine());

            P = p / (h * h);

            if (P < 20)
            {
                Console.Write("Você esta abaixo do peso ideal.");
            }

            else
            {
                if (P >= 25)
                {
                    Console.Write("Você esta acima do peso ideal.");
                }

                else
                {
                    Console.Write("Você esta no peso ideal!");
                }

            }

            Console.ReadKey();

        }
    }
}

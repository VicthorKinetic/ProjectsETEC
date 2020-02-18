using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis (p,h,s,P)
            //p = 1; h = 1; P = 0;
            //solicitar p
            //receber p
            //solicitar h
            //receber h
            //P = p/(h*h)
            //se s = M
              //se p < 20
                //exibir abaixo do peso
              //se não
                //se p >= 25
                  //exibir acima do peso
                //se não
                  //exibir peso ideal
            //se não
              //se p < 19
                //exibir abaixo do peso
              //se não
                //se p >= 24
                  //exibir acima do peso
                //se não
                  //exibir peso ideal

            double p, h, P; char s; char M;
            p = 1; h = 1; P = 0; s = char.Parse(" "); M = char.Parse("M");

            Console.Write("Digite seu peso: ");
            p = double.Parse(Console.ReadLine());
            Console.Write("Digite sua altura: ");
            h = double.Parse(Console.ReadLine());
            Console.Write("Digite seu sexo (M ou F) : ");
            s = char.Parse(Console.ReadLine());

            P = p / (h * h);

            if (s == M)
            {
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
            }

            else
            {
                if (P < 19)
                {
                    Console.Write("Você esta abaixo do peso ideal.");
                }

                else
                {
                    if (P >= 24)
                    {
                        Console.Write("Você esta acima do peso ideal.");
                    }

                    else
                    {
                        Console.Write("Você esta no peso ideal!");
                    }

                }
            }


            

            Console.ReadKey();
        }
    }
}

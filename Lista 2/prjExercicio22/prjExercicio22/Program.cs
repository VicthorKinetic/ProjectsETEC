using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis(a,t,vi,v)
            //a = 1; t = 1; vi = 0; v = 0;
            //solicitar a
            //receber a
            //solicitar t
            //receber t
            //solicitar vi
            //receber vi
            //v = vi + (a * t)
            //v = v * 3,6
            //se v <= 40
              //exibir veículo muito lento
            //se não
              //se v > 120
                //exibir veículo muito rápido
              //se não
                //se v > 80
                  //se v <= 120
                    //exibir veículo rápido
                  //se não
                //se não
                  //se v > 60
                    //se v <= 80
                      //exibir velocidade de cruzeiro
                  //se não
                    //se v > 40
                      //se v <= 60
                        //exibir velocidade permitida
                      //se não
                    //se não

            double a, t, vi, v;
            a = 1; t = 1; vi = 0; v = 0;

            Console.Write("Digite a aceleração do veículo: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o tempo de percurso do veículo: ");
            t = double.Parse(Console.ReadLine());
            Console.Write("Digite a velocidade inicial do veículo: ");
            vi = double.Parse(Console.ReadLine());

            v = vi + (a * t);
            v = v * 3.6;

            if (v <= 40)
            {
                Console.Write("O veículo está muito lento.");
            }

            else
            {
                if (v > 120)
                {
                    Console.Write("O veículo está muito rápido.");
                }

                else
                {
                    if (v > 80)
                    {
                        if (v <= 120)
                        {
                            Console.Write("O veículo está rápido.");
                        }

                        else { }

                    }

                    else
                    {
                        if (v > 60)
                        {
                            if (v <= 80)
                            {
                                Console.Write("O veículo está andando na velocidade de cruzeiro.");
                            }

                            else 
                            {
                                if (v > 40)
                                {
                                    if (v <= 60)
                                    {
                                        Console.Write("O veículo está andando na velocidade permitida.");
                                    }
                                }
                            }


                        }


                    }
                }
            }


            Console.ReadKey();
                    



        }
    }
}

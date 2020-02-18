using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis (l1,l2,l3)
            //l1 = 0; l2 = 0; l3 = 0;
            //solicitar l1
            //receber l1
            //solicitar l2
            //receber l2
            //solicitar l3
            //receber l3
            //se l1 + l2 > l3
              //se l2 + l3 > l1
                //se l1 + l3 > l2
                  //se l1 = l2
                    //se l1 = l3
                         //exibir equilatero
                     //se não
                         //exibir isósceles
                    //se não
                      //se l2 = l3
                        //exibir isósceles
                      //se não
                       //se l3 = l1
                        //exibir isósceles
                    //se não
                        //exibir escaleno
                 //se não
                  //exibir não é triangulo
               //se não
                //exibir não é triangulo
            //se não
              //exibir não é triangulo


            int l1, l2, l3;
            l1 = 0; l2 = 0; l3 = 0;

            Console.Write("Digite o valor de um lado: ");
            l1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de um outro lado: ");
            l2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de mais um lado: ");
            l3 = int.Parse(Console.ReadLine());

            if (l1 + l2 > l3)
            {
                if (l2 + l3 > l1)
                {
                    if (l1 + l3 > l2)
                    {
                        if (l1 = l2)
                        {
                            if (l1 = l3)
                            {
                                Console.Write("O triângulo é equilátero.");
                            }

                            else
                            {
                                Console.Write("O triângulo é isósceles.");
                            }
                        }

                        else
                        {
                            if (l2 = l3)
                            {
                                Console.Write("O triângulo é isósceles.");
                            }

                            else
                            {
                                if (l3 = l1)
                                {
                                    Console.Write("O triângulo é ísósceles.");
                                }

                                else
                                {
                                    Console.Write("O triângulo é escaleno.");
                                }
                            }
                        }
                    }

                    else
                    {
                        Console.Write("Não é possível construir um triângulo.");
                    }
                }

                else
                {
                    Console.Write("Não é possível construir um triângulo.");
                }
            }


            else
            {
                Console.Write("Não é possível construir um triângulo.");
            }

            Console.ReadKey();















        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis (b,h,A)
            //b = 1; h = 1; A = 0;
            //solicitar b
            //receber b
            //solicitar h
            //receber h
            //A = b * h
            //se A > 100
             //exibir "Terreno Grande"
            //se não
             //


            int b, h, A;
            b = 1; h = 1; A = 0;

            Console.Write("Insira a base do retângulo: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Insira a altura do retângulo: ");
            h = int.Parse(Console.ReadLine());

            A = b * h;

            if (A > 100)
            {
                Console.Write("Terreno grande, sua área é igual a: " + A.ToString());
            }

            else
            {
                Console.Write("A área é igual a: " + A.ToString());
            }
            Console.ReadKey();



        }
    }
}

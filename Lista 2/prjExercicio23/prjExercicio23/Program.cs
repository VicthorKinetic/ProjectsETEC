using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis (n1,n2,m)
            //n1 = 0; n2 = 1; m = 0;
            //solicitar nota 1
            //receber nota 1
            //solicitar nota 2
            //receber nota 2
            //m = (n1 + (n2*2)) / 3
            //se m < 5
              //Reprovado
            //se não
              //Aprovado

            double n1, n2, m;
            n1 = 0; n2 = 1; m = 0;

            Console.Write("Digite a primeira nota do aluno: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota do aluno: ");
            n2 = double.Parse(Console.ReadLine());

            m = (n1 + (n2*2)) / 3;

            if (m < 5)
            {
                Console.Write("Reprovado");
            }
            else
            {
                Console.Write("Aprovado");
            }
            Console.ReadKey();
        }
    }
}

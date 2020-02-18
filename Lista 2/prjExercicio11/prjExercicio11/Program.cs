using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis (n1,n2,n3,m)
            //n1 = 0; n2 = 0; n3 = 0; m = 0;
            //solicitar nota 1
            //receber nota 1
            //solicitar nota 2
            //receber nota 2
            //solicitar nota 3
            //receber nota 3
            //m = n1 + n2 + n3 / 3
            //se m < 5
             //Reprovado
            //se não
             //Aprovado

            double n1, n2, n3, m;
            n1 = 0; n2 = 0; n3 = 0; m = 0;

            Console.Write("Digite a primeira nota do aluno: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota do aluno: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a ultima nota do aluno: ");
            n3 = double.Parse(Console.ReadLine());

            m = (n1 + n2 + n3) / 3;

            if (m < 5)
            {
                Console.Write("Reprovado");
            }
            else {Console.Write("Aprovado");
            }
            Console.ReadKey();

        }
    }
}

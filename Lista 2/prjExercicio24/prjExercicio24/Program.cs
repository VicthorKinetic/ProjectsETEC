using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis (n1,n2)
            //n1 = 0; n2 = 0;
            //solicitar nota 1
            //receber nota 1
            //n2 = (15 - n1)/2


            double n1, n2;
            n1 = 0; n2 = 1;

            Console.Write("Digite a primeira nota do aluno: ");
            n1 = double.Parse(Console.ReadLine());

            n2 = (15 - n1) / 2;

            Console.Write("O aluno deve tirar " + n2 + " na segunda prova para ser aprovado com média 5 exata.");

           
            Console.ReadKey();
        }
    }
}

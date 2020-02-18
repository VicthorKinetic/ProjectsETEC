using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis (n1,n2,n3)
            //n1 = 0; n2 = 0; n3 = 0;
            //solicitar n1
            //receber n1
            //solicitar n2
            //receber n2
            //solicitar n3
            //receber n3
            //se n1 > n2
             //se n1 > n3
              //exibir n1
             //se não
              //exibir n3
            //se não
             //se n2 > n3
              //exibir n2
             //se não
              //exibir n3

            int n1, n2, n3;
            n1 = 0; n2 = 0; n3 = 0;

            Console.Write("Insira um número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Insira o segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Insira o último número: ");
            n3 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                if (n1 > n3) { Console.Write("O maior número é o primeiro inserido, ou seja: " + n1.ToString()); }
                else { Console.Write("O maior número é o terceiro inserido, ou seja: " + n3.ToString()); }
            }
            else
            {
                if (n2 > n3) { Console.Write("O maior número é o segundo inserido, ou seja: " + n2.ToString()); }
                else { Console.Write("O maior número é o terceiro inserido, ou seja: " + n3.ToString()); }
            }
                Console.ReadKey();
        }
    }
}

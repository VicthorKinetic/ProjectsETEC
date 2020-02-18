using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis (n1,n2)
            //n1 = 0; n2 = 0;
            //solicitar n1
            //receber n1
            //solicitar n2
            //receber n2
            //se n1 > n2
            //apresentar n1
            //se não
            //apresentar n2


            int n1, n2;
            n1 = 0; n2 = 0;

            Console.Write("Digite um número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.Write("O maior é o primeiro número inserido, ou seja: " + n1.ToString());
            }
            
            else
            {
                Console.Write("O maior é o segundo número inserido, ou seja: " +n2.ToString());}

            Console.ReadKey();
        

        }
    }
}

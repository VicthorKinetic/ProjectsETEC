using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercício3
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarar variaveis (n1,n2,resu)
            // n1 = 0; n2 = 0; resu = 0
            // solicitar n1
            // receber n1
            // solicitar n2
            // receber n2
            // resu = (n1 + n2) / 2
            // exibir resu

            double n1,n2;
            double resu;

            Console.Write("Digite o primeiro número: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n2 = double.Parse(Console.ReadLine());

            resu = (n1 + n2) / 2;

            Console.Write("A média entre os números é igual a: " + resu.ToString());
            Console.ReadKey();

 

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio34
{
    class Program
    {
        static void Main(string[] args)
        {

            //declarar variaveis(resu,n)
            //zerar variaveis
            //n = 1
            //resu = 1
            //repitir
              //n = n + 1
              //resu = resu + n
            //até n = 100


            int resu = 1, n = 1;

            do
            {
                n = n + 1;
                resu = resu + n;
            }
            while (n != 100);

            Console.Write("A soma dos números inteiros positivos do intervalo de um a cem é igual a: " + resu.ToString());
            Console.ReadKey();




        }
    }
}

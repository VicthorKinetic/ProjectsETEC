using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio53
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] i = new int[100];
            string[] n = new string[100];
            string[] s = new string[100];
            int x = 0;
            int y = -1;
            do
            {
                y = y + 1;
                x = x + 1;
                Console.Write("Digite o nome da " + x + "° pessoa: ");
                n[y] = Console.ReadLine();

                do
                {
                Console.Write("Digite o sexo da " + x + "° pessoa(F ou M): ");
                s[y] = Console.ReadLine();
                }
                while (s[y] != "F" && s[y] != "M");

                do
                {
                    Console.Write("Digite a idade da " + x + "° pessoa: ");
                    i[y] = int.Parse(Console.ReadLine());
                    Console.Clear();
                } 
                while (i[y] < 0);
            }
            while (x != 100);

            x=-1;

            do
            {
                x = x + 1;
                if (s[x] == "f" || s[x] == "F")
                {
                    Console.WriteLine("Nome: "+n[x]);
                    Console.WriteLine("Sexo: "+s[x]);
                    Console.WriteLine("Idade: "+i[x]);
                    Console.WriteLine("");
                }
            }
            while (x != 99);
            Console.ReadKey();
        }
    }
}

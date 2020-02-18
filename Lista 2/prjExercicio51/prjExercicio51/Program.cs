using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio51
{
    class Program
    {
        static void Main(string[] args)
        {


            int x, y, v, o, t;
            string i;

            do
            {

                x = 0; y = 0; v = 0; o = 0; i = ""; t = -1;


                do
                {
                    Console.Clear();
                    Console.Write("Digite a quantidade de valores que será digitada(max:20): ");
                    x = int.Parse(Console.ReadLine());

                    if (x < 1 || x > 20)
                    {
                        Console.Write("Erro,digite um valor valido");
                        Console.ReadKey();
                    }

                }
                while (x < 1 || x > 20);
                
                Console.Clear();


                int[] u = new int[x];

                do
                {
                    t = t + 1;
                    y = y + 1;
                    Console.Write("Digite o " + y + "° valor: ");
                    
                    u[t] = int.Parse(Console.ReadLine());




                }
                while (y != x);
                Console.Clear();

                Console.Write("Digite o valor para ser encontrado: ");
                v = int.Parse(Console.ReadLine());

                t = -1;
                y = 0;

                do
                {
                    t = t + 1;
                    y = y + 1;

                    if (v == u[t])
                    {
                        o = o + 1;
                        Console.WriteLine(y + "° Posição");
                    }
                }
                while (y != x);


                if (o == 0)
                {
                    Console.Clear();
                    Console.Write("Valor não encontrado!");
                    Console.ReadKey();

                }
                else
                {
                    Console.ReadKey();
                }


                do
                {
                    Console.Clear();
                    Console.WriteLine("Deseja realizar uma nova consulta?(Digite s=Sim ou n=Não) :");
                    i = Console.ReadLine();
                }
                while (i != "n" && i != "N" && i != "s" && i != "S");

            }
            while (i != "n"&&i !="N");
        }
    }
}

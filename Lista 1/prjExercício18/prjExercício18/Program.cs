using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercício18
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c,d,e,troco,pagamento;
            a = 1;
            b = 1;
            c = 1;
            d = 1;
            e = 1;
            pagamento = 1;
            troco = 1;

            Console.Write("Digite o primeiro valor: ");
            a = double.Parse (Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            c = double.Parse(Console.ReadLine());

            Console.Write("Digite o quarto valor: ");
            d = double.Parse(Console.ReadLine());

            Console.Write("Digite o último valor: ");
            e = double.Parse(Console.ReadLine());

            troco = a + b + c + d + e;

            Console.WriteLine("Ok, temos o resultado: " + troco.ToString());
            Console.WriteLine("Quanto seria o pagamento?");
            pagamento = double.Parse(Console.ReadLine());

            troco = pagamento - troco;

            Console.WriteLine("Seu troco é igual a: " + troco.ToString());
            Console.WriteLine("Aqui está seu troco; Obrigado, volte sempre");
            Console.ReadKey();
        }
    }
}

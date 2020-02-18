using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarar variaveis (ano,idade)
            // ano = 0; idade = 0
            // solicitar ano
            // receber ano
            // idade = 2015 - ano
            // exibir idade

            int ano, idade;
            ano = 0; idade = 0;

            Console.Write("Insira o ano de seu nascimento: ");
            ano = int.Parse (Console.ReadLine());
            idade = 2015 - ano;

            Console.Write("A sua idade é igual a " + idade.ToString());

            Console.ReadKey();




        }
    }
}

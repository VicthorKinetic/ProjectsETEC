using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis (nome,sobrenome.completo)
            //nome = ""; sobrenome = "";completo = "";
            //solicitar nome
            //receber nome
            //solicitar sobrenome
            //receber sobrenome
            //completo = nome + sobrenome;
            //exibir completo

            string nome, sobrenome, completo;
            nome = ""; sobrenome = ""; completo = "";

            Console.Write("Digite seu primeiro nome: ");
            nome = (Console.ReadLine());
            Console.Write("Digite seu sobrenome(s): ");
            sobrenome = (Console.ReadLine());

            completo = nome + " "+ sobrenome;

            Console.Write("Seu nome completo é: " + completo);
            Console.ReadKey();




        }
    }
}

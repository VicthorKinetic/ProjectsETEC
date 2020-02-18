using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjExercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis (nome,sexo)
            //nome = ""; sexo = "";
            //solicitar nome
            //receber nome
            //solicitar sexo
            //receber sexo
            //se sexo = M
             //"Olá, " + nome "! Bem-vindo!"
            //se não
             //"Olá, " + nome "! Bem-vinda!"


            string nome; char sexo; char S;
            nome = ""; S = char.Parse("M");

            Console.Write("Por favor, insira seu nome: ");
            nome = (Console.ReadLine());

            Console.Write("Por favor, insira se sexo, M ou F: ");
            sexo = char.Parse (Console.ReadLine());

            if (sexo == S ) 
            {
                Console.Write("Olá, " + nome + "! Bem-vindo!");
            }

            else
            {
                Console.Write("Olá, " + nome + "! Bem-vinda!");
            }

            Console.ReadKey();






        }
    }
}

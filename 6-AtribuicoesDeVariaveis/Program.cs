using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6");

            int idade = 24;
            int idadePatricia = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadePatricia);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");
            int idadeJoao = 16;
            int quantidadePessoas = 2;

            bool maiorDeIdade = idadeJoao >= 18;
            bool acompanhado = quantidadePessoas >= 2;
            string mensagemAdicional;


            if (acompanhado)
            {
                mensagemAdicional = "João está acompanhado";

            }
            else { 
                mensagemAdicional = "João não está acompanhado";
                Console.WriteLine( mensagemAdicional);

            }

            if (acompanhado || maiorDeIdade)
            {
                Console.WriteLine("Pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }

            else
                Console.WriteLine("Não pode entrar.");

            Console.ReadLine();

        }
    }
}

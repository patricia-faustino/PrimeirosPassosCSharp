﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais 2");
            int idadeJoao = 16;
            int quantidadePessoas = 2;

            /* bool maiorDeIdade = idadeJoao >= 18;
             bool acompanhado = quantidadePessoas >= 2;*/

            bool acompanhado = true;

            if (acompanhado)
            {
                Console.WriteLine("Pode entrar.");
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }

            Console.ReadLine();

        }
    }
}

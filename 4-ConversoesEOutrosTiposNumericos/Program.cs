using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            float altura = 1.80f;

            int salarioInteiro =(int)salario;

            Console.WriteLine(salarioInteiro);
            
            //suporta valores maiores que o int, 64bits
            long idade = 1300000000000;
             
            //suporta valores menores que o int, 16 bits
            short quantidadeProdutos = 150;

            Console.ReadLine();
        }
    }
}

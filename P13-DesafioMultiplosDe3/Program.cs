using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_DesafioMultiplosDe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 14");

            for(int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}

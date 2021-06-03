using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Caracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5- Caracteres e textos");

            // character
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)62;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de Tecnologia" + 200;
            Console.WriteLine(titulo);

            string cursosProgramacao = @" 
            - .NET
            - Java
            - Javascript";
            Console.WriteLine(cursosProgramacao);

            Console.ReadLine();

        }
    }
}

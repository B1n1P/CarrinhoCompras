using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosProgramas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ola como te chamas? ");
            //criar variável Nome
            String Nome = Console.ReadLine();
            Console.WriteLine("Bem vindo {0}.",Nome);
            Console.ReadKey();
        }
    }
}

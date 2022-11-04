using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosProgramas
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            int numero1, numero2, soma;
            Console.WriteLine("Digite um numero ");
            numero1 = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("Digite o segundo numero ");
            numero2 = Convert.ToInt32( Console.ReadLine() );
            soma = numero1 + numero2;
            Console.WriteLine("A soma de {0} com {1} = {2}", numero1, numero2, soma);

            Console.ReadKey();

        }
    }
}

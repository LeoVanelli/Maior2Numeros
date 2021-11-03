using System;

namespace Maior2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            Single.TryParse(Console
            .ReadLine()
            .ToString(), out Single _primeiroNumero );

            Console.Write("Digite o segundo número: ");
            Single.TryParse(Console
            .ReadLine()
            .ToString(), out Single _segundoNumero );

            Single _maiorNumero = (_primeiroNumero >= _segundoNumero) ? _primeiroNumero : _segundoNumero;
            Console.WriteLine($"Maior número: {_maiorNumero}");
        }
    }
}

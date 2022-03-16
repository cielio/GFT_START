using Questao3.Moldels;
using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            var contaCorrente = new ContaCorrente(1254, "Cielio",1000.00);
            var contaPoupanca = new ContaPoupanca(1454, "João", 1000.00);

            Console.WriteLine($"Redimento do {contaCorrente.Titular} = {contaCorrente.Rendimento():C}");
            Console.WriteLine($"Redimento do {contaPoupanca.Titular} = {contaPoupanca.Rendimento():C}");
        }
    }
}

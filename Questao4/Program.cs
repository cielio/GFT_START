using Questao4.Moldels;
using System;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Cielio", 72.00, 1.69);
            Console.WriteLine(pessoa.ToString());
            pessoa.ImprimirResult();
        }
    }
}

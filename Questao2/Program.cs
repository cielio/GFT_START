using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = ControlaEntrada();

            int nImpares = ContNunImpares(entrada);
            Console.WriteLine($"Total de Numeros Impares: {nImpares}");
        }

        public static string ControlaEntrada()
        {
            string entrada = "";
            while (entrada.Length < 3)
            {
                entrada = Console.ReadLine();
                int numero = int.Parse(entrada);

                if (entrada.Length < 3)
                {
                    Console.WriteLine("A entrada tem que conter 3 dígitos");

                }else if (numero >= 350 && numero <= 8750)
                {
                    return entrada;
                }
                else 
                {
                    entrada = "";
                    Console.WriteLine("A entrada deve estar entre 350 e 8750");
                }
            }
            return entrada;
        }

        public static int ContNunImpares(string entrada)
        {
            int cont = 0;

            for (int i = 0; i < entrada.Length; i++)
            {
                var numero = int.Parse(entrada[i].ToString());
                if (numero % 2 != 0)
                {
                    cont++;
                }
            }
            return cont;
        }
    }
}

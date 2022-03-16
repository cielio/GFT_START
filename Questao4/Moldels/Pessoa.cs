using System;

namespace Questao4.Moldels
{
    public class Pessoa
    {
        public string Nome { get; private set; }
        public double Peso { get; private set; }
        public double Altura { get; private set; }

        public Pessoa(string nome, double peso, double altura)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
        }

        public double CalcImc()
        {
            double totalImc = Peso / (Altura * Altura);
            return totalImc;
        }

        public void ImprimirResult()
        {
            var imc = CalcImc();

            Console.WriteLine("-----------Categoria------------");

            if (imc <= 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc > 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Peso Normal");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine("Obsidade Grau I");
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine("Obsidade Grau II");
            }
            else if (imc >= 40)
            {
                Console.WriteLine("Obsidade Grau III");
            }
        }
        public override string ToString()
        {
            return $"Nome {Nome} | Altura: {Altura} | Peso: {Peso} | IMC: {CalcImc():F2}";
        }
    }
}

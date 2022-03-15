namespace Questao1.Moldels
{
    public abstract class Colaborador
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public double Salario { get; private set; }
        public int GrauInstrucao { get; private set; }
        protected Colaborador(string nome, int idade, double salario, int grauInstrucao)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
            GrauInstrucao = grauInstrucao;
        }

        public abstract double Bonificacao();

    }
}

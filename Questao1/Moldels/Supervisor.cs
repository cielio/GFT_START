namespace Questao1.Moldels
{
    public class Supervisor : Colaborador
    {
        public Supervisor(string nome, int idade, double salario, int grauInstrucao)
            : base(nome, idade, salario, grauInstrucao)
        {
        }

        public override double Bonificacao()
        {
            return (Salario + 500.00) * (GrauInstrucao * 3);
        }

    }
}

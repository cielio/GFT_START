namespace Questao1.Moldels
{
    public class Gerente : Colaborador
    {
        public Gerente(string nome, int idade, double salario, int grauInstrucao)
            : base(nome, idade, salario, grauInstrucao)
        {
        }

        public override double Bonificacao()
        {
            return (Salario + 1000.00) * (GrauInstrucao * 2);
        }

    }
}

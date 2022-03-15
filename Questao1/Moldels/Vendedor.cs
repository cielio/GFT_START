namespace Questao1.Moldels
{
    public class Vendedor : Colaborador
    {
        public Vendedor(string nome, int idade, double salario, int grauInstrucao)
            : base(nome, idade, salario, grauInstrucao)
        {
        }

        public override double Bonificacao()
        {
            return (Salario + 300.00) * (GrauInstrucao * 4);
        }

    }
}

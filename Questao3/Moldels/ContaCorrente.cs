namespace Questao3.Moldels
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int numero, string titular, double saldo)
            : base(numero, titular, saldo)
        {
        }
        public override double Rendimento()
        {
            return (Saldo * 0.05) - 0.75;
        }
    }
}

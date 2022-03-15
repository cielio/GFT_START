using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3.Moldels
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(int numero, string titular, double saldo) 
            : base(numero, titular, saldo)
        {
        }

        public override double Rendimento()
        {
            return (Saldo * 0.07);
        }


    }
}

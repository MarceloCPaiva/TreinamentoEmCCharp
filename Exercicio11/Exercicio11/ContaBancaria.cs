using System.Globalization;

namespace Exercicio11
{
    class ContaBancaria
    {
        public int NumeroDaConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroDaConta, string nome)
        {
            NumeroDaConta = numeroDaConta;
            Nome = nome;
        }

        public ContaBancaria(int numeroDaConta, string nome, double depositoInicial) : this(numeroDaConta, nome)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo = (Saldo - saque) - 5.00;
        }

        public override string ToString()
        {
            return
                "Conta "
                + NumeroDaConta
                + ", Titular: "
                + Nome
                + ", Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

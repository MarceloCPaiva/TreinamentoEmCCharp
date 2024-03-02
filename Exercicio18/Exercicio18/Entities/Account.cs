using System;
using System.Collections.Generic;

namespace Exercicio18.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Name { get; private set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account() { }

        public Account(int number, string name, double balance, double withdrawLimit)
        {
            Number = number;
            Name = name;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit() { }
        
        public void Withdraw(double amount) //saque
        {
            if (amount > WithdrawLimit)
            {
                throw new InvalidOperationException("Erro de saque: o valor excede o limite de saque");
            }

            if(amount > Balance)
            {
                throw new InvalidOperationException("Erro de retirada: saldo insuficiente");
            }

            Balance-=amount;

        }

    }
}


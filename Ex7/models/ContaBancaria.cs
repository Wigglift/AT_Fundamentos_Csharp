using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7.models
{
    internal class ContaBancaria
    {
        public string Titular { get; set; }
        private double Saldo { get; set; }

        public ContaBancaria(string titular)
        {
            this.Titular = titular;
            this.Saldo = 0;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser positivo!");
            }
            else {
                Saldo += valor;
            }
        }

        public void Sacar(double valor)
        {
            if (valor > this.Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque!");
            } else
            {
                this.Saldo -= valor;
            }

            
        }

        public double ExibirSaldo()
        {
            return this.Saldo;
        }
    }   
}

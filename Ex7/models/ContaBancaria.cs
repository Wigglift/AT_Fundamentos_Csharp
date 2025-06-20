using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7.models
{
    internal class ContaBancaria
    {
        public string titular { get; set; }
        private double saldo { get; set; }

        public ContaBancaria(string titular)
        {
            this.titular = titular;
            this.saldo = 0;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser positivo!");
            }
            else {
                saldo += valor;
            }
        }

        public void sacar(double valor)
        {
            if (valor > this.saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque!");
            } else
            {
                this.saldo -= valor;
            }

            
        }

        public double exibirSaldo()
        {
            return this.saldo;
        }
    }   
}

namespace Ex7;

using System;

using Ex7.models;

public class Program
{
    public static void Main(String[] args)
    {
        // Criação de um objeto ContaBancaria com o titular "João"
        ContaBancaria conta = new ContaBancaria("João");

        Console.WriteLine("Titular da conta: " + conta.titular + "\n");

        Console.WriteLine("Realizando depósito de 1000 reais");
        conta.Depositar(1000);
        Console.WriteLine("Saldo após depósito: " + conta.exibirSaldo().ToString("C2") + "\n");

        Console.WriteLine("tentando depositar um valor negativo de -200 reais");
        conta.Depositar(-200);

        Console.WriteLine("\nTentando sacar um valor maior que o saldo");
        conta.sacar(1500);
        Console.WriteLine("Saldo após tentativa de saque: " + conta.exibirSaldo().ToString("C2") + "\n");

        Console.WriteLine("Realizando um saque válido de 500 reais");
        conta.sacar(500);
        Console.WriteLine("Saldo após saque: " + conta.exibirSaldo().ToString("C2") + "\n");
    }
}
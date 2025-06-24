namespace Ex8;

using System;
using Ex8.models;

class Program
{
    public static void Main(String[] args)
    {
        Funcionario funcionario = new Funcionario("João", "Vendedor");

        Gerente gerente = new Gerente("Maria", "Gerente de Vendas");


        // Exibindo os dados do funcionário
        Console.WriteLine("Dados do Funcionário:");
        Console.WriteLine($"Nome: {funcionario.Nome}");
        Console.WriteLine($"Cargo: {funcionario.Cargo}");
        Console.WriteLine($"Salário: {funcionario.SalarioBase.ToString("C2")}");

        // Exibindo os dados do gerente
        Console.WriteLine("\nDados do Gerente:");
        Console.WriteLine($"Nome: {gerente.Nome}");
        Console.WriteLine($"Cargo: {gerente.Cargo}");
        Console.WriteLine($"Salário: {gerente.SalarioBase.ToString("C2")}");
    }
}
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
        Console.WriteLine($"Nome: {funcionario.nome}");
        Console.WriteLine($"Cargo: {funcionario.cargo}");
        Console.WriteLine($"Salário: {funcionario.salarioBase.ToString("C2")}");

        // Exibindo os dados do gerente
        Console.WriteLine("\nDados do Gerente:");
        Console.WriteLine($"Nome: {gerente.nome}");
        Console.WriteLine($"Cargo: {gerente.cargo}");
        Console.WriteLine($"Salário: {gerente.salarioBase.ToString("C2")}");
    }
}
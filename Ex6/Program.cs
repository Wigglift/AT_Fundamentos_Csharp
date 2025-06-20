namespace Ex6;

using System;
using Ex6.models;

public class Program
{
    public static void Main(String[] args)
    {
        // Criação de um objeto Aluno com os dados fornecidos
        Aluno aluno = new Aluno("Isaac", 123456, "Engenharia de Software", 8.5);

        aluno.exibirDados(); // Exibe os dados do aluno

        Console.WriteLine("Situação: " + aluno.verificarAprovacao()); // Verifica e exibe a situação do aluno (aprovado ou reprovado)

    }
}
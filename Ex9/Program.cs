namespace Ex9;

using System;
using System.Runtime.InteropServices;
using Ex9.models;

public class Program
{
    public static void Main(String[] args)
    {
        bool sair = false; // Variável para controlar o loop do menu
        do
        {
            ExibirMenu(); // Exibe o menu de opções para o usuário
                          
            int operacao = Usuario.RequisitarInteiro("Digite o número da operação desejada: ",1,3, ExibirMenu);// Solicita ao usuário que escolha uma operação válida entre 1 e 3, com o menu sendo exibido novamente em caso de erro.

            switch (operacao)
            {
                case 1:
                    Produto produto =  MontarProduto();// Monta o produto com os dados fornecidos pelo usuário
                    Estoque.InserirProduto(produto); // Adiciona o produto ao estoque
                    break;    

                case 2:
                    Estoque.ListarProdutos();
                    break;

                case 3:
                    sair = true; // Define sair como true para encerrar o loop
                    Console.WriteLine("Saindo do programa...");
                    break;
            }
        } while (!sair);
    }

    static void ExibirMenu()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Adicionar Produto");
        Console.WriteLine("2. Listar Produtos");
        Console.WriteLine("3. Sair");
        Console.Write("Escolha uma opção: ");
    }

    static Produto MontarProduto()
    {

        if (Estoque.EstoqueCheio() == true) return null; // Verifica se o estoque está cheio antes de permitir a adição de um novo produto

        Console.WriteLine("\nDigite o nome do produto:");

        string nome = Console.ReadLine();

        int quantidadeNoEstoque = Usuario.RequisitarInteiro("\nDigite a quantidade no estoque: ", 0);

        double preco = Usuario.RequisitarPreco("\nDigite o preço do produto (Use a virgula para separar os centavos ex: 23,45): ");

        Produto produto = new Produto(nome, quantidadeNoEstoque, preco);

        return produto;
    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9.models
{
    public class Produto
    {
        String nome { get; set; }
        int quantidadeEmEstoque { get; set; }
        double preco { get; set; }

        
        public Produto(String nome, int quantidadeEmEstoque, double preco)
        {
            this.nome = nome;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
            this.preco = preco;
        }
        
        internal void exibirDados()
        {
            Console.Write("\nNome: " + this.nome);
            Console.Write(" | Quantidade em Estoque: " + this.quantidadeEmEstoque);
            Console.Write(" | Preço: " + this.preco.ToString("C2"));
        }

        public override string ToString()
        {
            // Retorna uma representação em string do produto, que será usada para escrever no arquivo
            return $"{this.nome},{this.quantidadeEmEstoque},{this.preco.ToString("F2")}";
        }
    }
}

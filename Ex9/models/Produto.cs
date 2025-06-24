using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9.models
{
    public class Produto
    {
        String Nome { get; set; }
        int QuantidadeEmEstoque { get; set; }
        double Preco { get; set; }

        
        public Produto(String nome, int quantidadeEmEstoque, double preco)
        {
            this.Nome = nome;
            this.QuantidadeEmEstoque = quantidadeEmEstoque;
            this.Preco = preco;
        }
        
        internal void ExibirDados()
        {
            Console.Write("\nNome: " + this.Nome);
            Console.Write(" | Quantidade em Estoque: " + this.QuantidadeEmEstoque);
            Console.Write(" | Preço: " + this.Preco.ToString("C2"));
        }

        public override string ToString()
        {
            // Retorna uma representação em string do produto, que será usada para escrever no arquivo
            return $"{this.Nome},{this.QuantidadeEmEstoque},{this.Preco.ToString("F2")}";
        }
    }
}

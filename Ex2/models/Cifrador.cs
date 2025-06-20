using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.models
{
    internal class Cifrador
    {
        private string palavra;
        private string resultado;

        public Cifrador(string palavra)
        {
            this.palavra = palavra;
            
            this.resultado = cifrar(palavra);
        }

        // Nesse método criamos um array de caracteres vazio e vamos analisando cada letra da da palavra e como caractere é um tipo de integer somamos + 2 para transformar na 
        // letra 2 posições a frente e colocamos isso no array de caractere, no final criamos o retor que vai ser uma string construída a partir desse array de caracteres
        public string cifrar(string palavra)
        {
            char[] resultado = new char[palavra.Length];
            int i = 0;

            foreach (char c in palavra)
            {
                resultado[i] = (char)(c + 2);
                i++;
            }

            string retorno = new string(resultado);

            return retorno;
        }

        public string mostrarResultado() {

            return this.resultado;

        }
    }
}

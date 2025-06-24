using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.models
{
    internal class Cifrador
    {
        public string Palavra { get; set; }

        public Cifrador(string palavra)
        {
            Palavra = palavra;
        }

        // Nesse método criamos um array de caracteres vazio e vamos analisando cada letra da da palavra e como caractere é um tipo de integer somamos + 2 para transformar na 
        // letra 2 posições a frente e colocamos isso no array de caractere, no final criamos o retor que vai ser uma string construída a partir desse array de caracteres
        public string Cifrar()
        {
            char[] resultado = new char[Palavra.Length];
            int i = 0;

            foreach (char c in Palavra)
            {
                resultado[i] = (char)(c + 2);
                i++;
            }

            string retorno = new string(resultado);

            return retorno;
        }
    }
}

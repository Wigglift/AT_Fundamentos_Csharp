using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exer12.models.superclass;

namespace Exer12.models
{
    internal class RawTextFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine();

            foreach (Contato contato in contatos)
            {
                Console.WriteLine($"Nome: {contato.Nome} | Telefone {contato.Telefone} | Email: {contato.Email}");
                Console.WriteLine();

            }
        }


    }
}

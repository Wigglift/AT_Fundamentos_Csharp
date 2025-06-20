using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Exer12.models.superclass;

namespace Exer12.models
{
    public class MarkdownFormatter : ContatoFormatter { 
    
    public override void ExibirContatos(List<Contato> contatos)
        {
            foreach (Contato contato in contatos)
            {
                Console.WriteLine($"- **Nome:** {contato.Nome}");
                Console.WriteLine($"- Telefone: {contato.Telefone}");
                Console.WriteLine($"- @Email: {contato.Email}");
                Console.WriteLine();
            }
        }
    } 
}

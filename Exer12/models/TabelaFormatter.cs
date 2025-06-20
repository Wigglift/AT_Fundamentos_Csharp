using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exer12.models.superclass;

namespace Exer12.models
{
    internal class TabelaFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("_____________________________________________________________________________________");
            Console.WriteLine("| Nome                 | Telefone           | Email                     |");
            Console.WriteLine("_____________________________________________________________________________________");
            foreach (Contato contato in contatos)
            {
                Console.WriteLine($"| {contato.Nome,-20} | {contato.Telefone,-18} | {contato.Email,-25} |");
                Console.WriteLine("_____________________________________________________________________________________");
            }
        }
    }
    
    
}

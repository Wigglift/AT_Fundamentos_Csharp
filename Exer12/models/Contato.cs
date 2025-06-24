using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer12.models
{
    public class Contato
    {
        public string Nome { get; set; }

        private String telefone;

        public string Email { get; set; }

        public String Telefone
        {
            get { return telefone; }
            set
            {
                if (!value.Contains("-"))
                {
                    // Verifica se o telefone já está formatado com o hífen

                    if (value.Length == 11)
                    {
                        // Formata o telefone para o padrão (XX) XXXXX-XXXX
                        telefone = value.Insert(2, " ");
                        telefone = telefone.Insert(8, "-");

                    }
                    else
                    {
                        // Formata o telefone para o padrão (XX) XXXX-XXXX
                        telefone = value.Insert(2, " ");
                        telefone = telefone.Insert(7, "-");
                    }
                }
                else
                {

                    telefone = value;

                }
            }

        }   
        


        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Nome},{Telefone},{Email}";
        }
    }
}

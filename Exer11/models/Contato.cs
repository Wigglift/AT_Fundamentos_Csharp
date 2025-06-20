using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer11.models
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
                if (value.Length == 11)
                {
                    telefone = value.Insert(2, " ");
                    telefone = telefone.Insert(8, "-");
                }
                else
                {
                    telefone = value.Insert(2, " ");
                    telefone = telefone.Insert(7, "-");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8.models
{
    public class Funcionario
    {
        public String nome { get; set; }
        public String cargo { get; set; }
        public double salarioBase { get; set; } = 2450.89;

        public Funcionario(String nome, String cargo)
        {
            this.nome = nome;
            this.cargo = cargo;
        }
    }
}

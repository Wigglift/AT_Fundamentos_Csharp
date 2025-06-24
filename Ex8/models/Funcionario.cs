using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8.models
{
    public class Funcionario
    {
        public String Nome { get; set; }
        public String Cargo { get; set; }
        public double SalarioBase { get; set; } = 2450.89;

        public Funcionario(String nome, String cargo)
        {
            this.Nome = nome;
            this.Cargo = cargo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8.models
{
    public class Gerente : Funcionario
    {
       
        public Gerente(String nome, String cargo) : base(nome, cargo) { 
        
            this.salarioBase = this.salarioBase*1.2; // Atribuindo um salário base específico para o Gerente

        }

    }
}

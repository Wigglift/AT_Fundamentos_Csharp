using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6.models
{
    public class Aluno
    {
        string nome { get; set; }
        int matricula { get; set; }

        string curso { get; set; } 
        
        double mediaDasNotas { get; set; }


        public Aluno(string nome, int matricula, string curso, double mediaDasNotas)
        {
            // Construtor da classe Aluno que inicializa os atributos
            this.nome = nome;
            this.matricula = matricula;
            this.curso = curso;
            this.mediaDasNotas = mediaDasNotas;
        }
    


        public void exibirDados()
        {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Matrícula: " + this.matricula);
            Console.WriteLine("Curso: " + this.curso);
            Console.WriteLine("Média das Notas: " + this.mediaDasNotas);
        }

        public String verificarAprovacao()
        {
            if (this.mediaDasNotas >= 7)
            {
                return "Aprovado";
            }
            
            else
            {
                return "Reprovado";
            }
        }
    }
}
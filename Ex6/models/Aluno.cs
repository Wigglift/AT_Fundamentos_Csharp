using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6.models
{
    public class Aluno
    {
        string Nome { get; set; }
        int Matricula { get; set; }

        string Curso { get; set; } 
        
        double MediaDasNotas { get; set; }


        public Aluno(string nome, int matricula, string curso, double mediaDasNotas)
        {
            // Construtor da classe Aluno que inicializa os atributos
            this.Nome = nome;
            this.Matricula = matricula;
            this.Curso = curso;
            this.MediaDasNotas = mediaDasNotas;
        }
    


        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Matrícula: " + this.Matricula);
            Console.WriteLine("Curso: " + this.Curso);
            Console.WriteLine("Média das Notas: " + this.MediaDasNotas);
        }

        public String VerificarAprovacao()
        {
            if (this.MediaDasNotas >= 7)
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer11.models
{
    public class ListaDeContatos
    {
        
        static String path { get; set; } =  "C:\\Users\\rodri\\Infnet\\Exer11\\Lista\\Lista.txt"; // Caminho do arquivo onde os contatos serão armazenados

        public static void InserirContato(Contato contato)
        {
            IniciarArq(); // Verifica se o arquivo existe, caso contrário, cria um novo

            StreamWriter escritor = null;

            try
            {
                escritor = new StreamWriter(path, true);

                escritor.WriteLine(contato.ToString());
                
                Console.WriteLine("\nContato inserido com sucesso.\n");
                escritor.Close();
            }
            catch (FileNotFoundException e1)
            {
                escritor.Close();
                Console.WriteLine("Arquivo não encontrado: " + e1.Message);
                
                
            }
            catch (Exception e)
            {
                escritor.Close();
                Console.WriteLine("Erro ao inserir contato: " + e.Message);
                
            }
        }
        public static void ListarContatos()
        {
            StreamReader leitor = null;
            try
            {
                leitor = new StreamReader(path);
                string contatoInfo = leitor.ReadLine();

                if(contatoInfo == null)
                {
                    leitor.Close();
                    throw new FileNotFoundException("Nenhum contato cadastrado."); // Lança uma exceção se não houver contatos cadastrados
                    
                }

                while (contatoInfo != null)
                {

                    string[] strings = contatoInfo.Split(',');

                    Console.WriteLine($"\nNome: {strings[0]} | Telefone:{strings[1]} | Email:{strings[2]}");

                    contatoInfo = leitor.ReadLine();
                }

                leitor.Close();

                Console.WriteLine();

            }
            catch (FileNotFoundException e1)
            {
                leitor.Close();
                Console.WriteLine("Nenhum contato cadastrado.");
                
            }
            catch (Exception e)
            {
                
                Console.WriteLine("Nenhum contato cadastrado.");
                
            }
        }
        private static void IniciarArq()
        {
            bool erro = false;
            do
            {
                try
                {
                    erro = false;
                    if (!File.Exists(path))
                    {
                        File.Create(path).Close();
                    }
                }
                catch (Exception e)
                {
                    // Se ocorrer um erro ao iniciar o arquivo, exibe uma mensagem de erro e solicita um novo caminho para armazenar o arquivo de texto
                    // Caso não funcione pela requisição do usuário, terá que mudar a variável path no código fonte
                    Console.WriteLine("Erro ao iniciar o arquivo: " + e.Message);

                    Console.WriteLine("\nInsira o diretório de onde vai ser armazenado as informações manualmente a seguir ou mude o caminho no código fonte(recomendado)");
                    var newPath = Console.ReadLine();

                    newPath = newPath.Replace("\\", "\\\\"); // Remove o barra normal por barra dupla para o sistema poder ler o caminho
                    path = newPath + "Lista.txt";

                    Console.WriteLine("Novo caminho adicionado");
                }
            } while (erro);
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exer12.models.superclass;

namespace Exer12.models
{
    public class ListaDeContatos
    {

        static String path { get; set; } = "C:\\Users\\rodri\\Infnet\\AT_C#\\Exer12\\Lista\\Lista.txt"; // Caminho do arquivo onde os contatos serão armazenados

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

            List<Contato> contatos = new List<Contato>(); // Lista para armazenar os contatos lidos do arquivo

            try
            {
                leitor = new StreamReader(path);
                string contatoInfo = leitor.ReadLine();

                if (contatoInfo == null)
                {
                    leitor.Close();
                    throw new FileNotFoundException("Nenhum contato cadastrado."); // Lança uma exceção se não houver contatos cadastrados

                }

                while (contatoInfo != null)
                {

                    Contato contato = MontarContato(contatoInfo);

                    contatos.Add(contato); // Adiciona o contato à lista


                    contatoInfo = leitor.ReadLine();
                }

                leitor.Close();
                Console.WriteLine();
                MenuExibicao();

                int opcaoExibicao = Usuario.RequisitarInteiro("Escolha um modo de exibição", 1, 4, MenuExibicao);

                ExibirContatos(opcaoExibicao, contatos); // Exibe os contatos de acordo com a opção escolhida pelo usuário

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

        public static void MenuExibicao()
        {
            Console.WriteLine("\n==Modo de exibição==\n");
            Console.WriteLine("1. Markdown");
            Console.WriteLine("2. Tabela");
            Console.WriteLine("3. Texto Puro");
            Console.WriteLine("4. Voltar");
        }

        public static void ExibirContatos(int opcao, List<Contato> contatos)
        {
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("\nExibindo em Markdown...\n");
                    ContatoFormatter markdownFormatter = new MarkdownFormatter();
                    markdownFormatter.ExibirContatos(contatos);
                    break;

                case 2:
                    Console.WriteLine("Exibindo em Tabela...");
                    ContatoFormatter tabelaFormatter = new TabelaFormatter();
                    tabelaFormatter.ExibirContatos(contatos);
                    break;

                case 3:
                    Console.WriteLine("Exibindo em Texto Puro...");
                    ContatoFormatter rawTextFormatter = new RawTextFormatter();
                    rawTextFormatter.ExibirContatos(contatos);
                    break;

                case 4:
                    Console.WriteLine("Voltando ao menu principal...");
                    break;
            }
        }

        private static Contato MontarContato(string contatoInfo)
        {
            string[] contatoDados = contatoInfo.Split(',');

            string nome = contatoDados[0];
            string email = contatoDados[1];
            string telefone = contatoDados[2];

            Contato contato = new Contato(nome, email, telefone);
            return contato;
        }
    }
}

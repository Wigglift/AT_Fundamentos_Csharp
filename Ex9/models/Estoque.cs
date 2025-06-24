using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9.models
{
    public class Estoque
    {
        static List<Produto> Produtos { get; set; } = new List<Produto>();// Lista estática para armazenar os produtos no estoque que estão sendo adicionados quando o programa é executado

        static String Path { get; set; } = "C:\\Users\\rodri\\Infnet\\AT_C#\\Ex9\\Lista\\Lista.txt";// Caminho do arquivo onde os produtos serão armazenados

     
        public static void InserirProduto(Produto produto)
        {
            {
                IniciarArq(); // Verifica se o arquivo existe, caso contrário, cria um novo
                try
                {
                    StreamWriter escritor = new StreamWriter(Path, true);
                    // Verifica se o estoque já está cheio (mais de 5 produtos)
                    if (EstoqueCheio())
                    {
                        Console.WriteLine("Estoque cheio, não é possível inserir mais produtos.");
                        escritor.Close();
                    }
                    else
                    {
                        escritor.WriteLine(produto.ToString());

                        Produtos.Add(produto);
                        Console.WriteLine("Produto inserido com sucesso.");
                        escritor.Close();
                    }

                }
                catch (FileNotFoundException e1)
                {// Se o arquivo não for encontrado, exibe uma mensagem de erro e encerra o método
                    Console.WriteLine("Arquivo não encontrado: " + e1.Message);
                    return;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao inserir produto: " + e.Message);

                }
            }
        }

        public static void ListarProdutos()
        {
            IniciarArq();// Verifica se o arquivo existe, caso contrário, cria um novo
            try
            {
                StreamReader leitor = new StreamReader(Path);

                // Verifica se a lista de produtos está vazia
                string produtoInfo = leitor.ReadLine();

                if (produtoInfo == null)
                {
                    Console.WriteLine("\nNão há produtos no estoque.\n");
                    leitor.Close();
                }
                else
                {
                    // Exibe os produtos no estoque através de um loop
                    Console.WriteLine("\nProdutos no estoque:");


                    while (produtoInfo != null)
                    {
                        string[] produtoDados = produtoInfo.Split(',');

                        Produto produto = new Produto(produtoDados[0], int.Parse(produtoDados[1]), double.Parse(produtoDados[2]));
                        produto.ExibirDados(); // Exibe os dados do produto

                        produtoInfo = leitor.ReadLine();

                    }
                }

                Console.WriteLine();
                leitor.Close();
            }
            catch (FileNotFoundException e1)// Se o arquivo não for encontrado, exibe uma mensagem de erro e encerra o método
            {
                Console.WriteLine("Arquivo não encontrado: " + e1.Message);
                return;
            }
            catch (Exception e2)
            {
                Console.WriteLine("Erro ao ler o arquivo: " + e2.Message);
                return;
            }
        }


        public static bool EstoqueCheio()
        {
            // Verifica se o estoque está cheio (mais de 5 produtos)
            return Produtos.Count > 4;
        }

        private static void IniciarArq()
        {
            bool erro = false;
            do
            {
                try
                {
                    erro = false;
                    if (!File.Exists(Path))
                    {
                        File.Create(Path).Close();
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
                    Path = newPath + "Lista.txt";

                    Console.WriteLine("Novo caminho adicionado");
                }
            } while (erro);
        }
    }
}
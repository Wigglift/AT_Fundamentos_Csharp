using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9.models
{
    public class Estoque
    {
        static List<Produto> produtos = new List<Produto>();// Lista estática para armazenar os produtos no estoque que estão sendo adicionados quando o programa é executado

        static String path = "C:\\Users\\rodri\\Infnet\\AT_C#\\Ex9\\Lista\\Lista.txt"; // Caminho do arquivo onde os produtos serão armazenados

     
        public static void inserirProduto(Produto produto)
        {
            {
                iniciarArq(); // Verifica se o arquivo existe, caso contrário, cria um novo
                try
                {
                    StreamWriter escritor = new StreamWriter(path, true);
                    // Verifica se o estoque já está cheio (mais de 5 produtos)
                    if (estoqueCheio())
                    {
                        Console.WriteLine("Estoque cheio, não é possível inserir mais produtos.");
                        escritor.Close();
                    }
                    else
                    {
                        escritor.WriteLine(produto.ToString());

                        produtos.Add(produto);
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

        public static void listarProdutos()
        {
            iniciarArq();// Verifica se o arquivo existe, caso contrário, cria um novo
            try
            {
                StreamReader leitor = new StreamReader(path);

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
                        produto.exibirDados(); // Exibe os dados do produto

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


        public static bool estoqueCheio()
        {
            // Verifica se o estoque está cheio (mais de 5 produtos)
            return produtos.Count > 4;
        }

        private static void iniciarArq()
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
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer11.models
{
    public class Usuario
    {
        public static int requisitarInteiro(String mensagem, int min, int max, Action menu)
        {
            bool erro = false;

            int x = 0; // Inicializa x com 0 para evitar erros de referência antes da atribuição

            do
            {//Loop para garantir que o usuário digite um número válido
                try
                {
                    erro = false; // Reseta o erro para false a cada iteração
                    Console.WriteLine(mensagem);
                    x = int.Parse(Console.ReadLine());

                    if (x < min || x > max)
                    {
                        throw new ArgumentOutOfRangeException($"O número inserido deve ser entre {min} e {max}.");
                    }
                }
                catch (FormatException e1)
                {
                    erro = true; // Se ocorrer um erro de formato, define erro como true para repetir o loop
                    Console.WriteLine("Erro: {0}. Por favor, digite um número válido.", "Formato inválido");
                    menu();
                }
                catch (ArgumentOutOfRangeException e2)
                {
                    erro = true;// Se ocorrer um erro, define erro como true para repetir o loop
                    Console.WriteLine("Erro: {0}. Por favor, digite um número válido.", $"A opção deve ser entre {min} e {max}.");
                    menu();
                }
                catch (Exception e3)
                {
                    Console.WriteLine("Erro: {0}. Por favor, digite um número válido.", e3.Message);
                    menu();
                }
            } while (erro);

            return x;
        }
        // Override de requisitarInteiro para caso não tenha um menu
        public static int requisitarInteiro(String mensagem, int min, int max)
        {
            bool erro = false;

            int x = 0; // Inicializa x com 0 para evitar erros de referência antes da atribuição

            do
            {//Loop para garantir que o usuário digite um número válido
                try
                {
                    erro = false; // Reseta o erro para false a cada iteração
                    Console.WriteLine(mensagem);
                    x = int.Parse(Console.ReadLine());

                    if (x < min || x > max)
                    {
                        throw new ArgumentOutOfRangeException($"O número inserido deve ser entre {min} e {max}.");
                    }
                }
                catch (FormatException e1)
                {
                    erro = true; // Se ocorrer um erro de formato, define erro como true para repetir o loop
                    Console.WriteLine("Erro: {0}. Por favor, digite um número válido.", "Formato inválido");
                    
                }
                catch (ArgumentOutOfRangeException e2)
                {
                    erro = true;// Se ocorrer um erro, define erro como true para repetir o loop
                    Console.WriteLine("Erro: {0}. Por favor, digite um número válido.", $"A opção deve ser entre {min} e {max}.");
                    
                }
                catch (Exception e3)
                {
                    Console.WriteLine("Erro: {0}. Por favor, digite um número válido.", e3.Message);
                    
                }
            } while (erro);

            return x;
        }
        // Override de requisitarInteiro para caso não haja limite máximo
        public static int requisitarInteiro(String mensagem, int min)
        {
            bool erro = false;

            int x = 0; // Inicializa x com 0 para evitar erros de referência antes da atribuição

            do
            {//Loop para garantir que o usuário digite um número válido
                try
                {
                    erro = false; // Reseta o erro para false a cada iteração
                    Console.WriteLine(mensagem);
                    x = int.Parse(Console.ReadLine());

                    if (x < min)
                    {
                        throw new ArgumentOutOfRangeException($"O número inserido deve ser maior que {min}");
                    }
                }
                catch (FormatException e1)
                {
                    erro = true; // Se ocorrer um erro de formato, define erro como true para repetir o loop
                    Console.WriteLine("Erro: {0}. Por favor, digite um número válido.", "Formato inválido");
                }
                catch (ArgumentOutOfRangeException e2)
                {
                    erro = true;// Se ocorrer um erro, define erro como true para repetir o loop
                    Console.WriteLine("Erro: {0}. Por favor, digite um número válido.", $"O número inserido deve ser maior que {min}");
                }
                catch (Exception e3)
                {
                    Console.WriteLine("Erro: {0}. Por favor, digite um número válido.", e3.Message);
                }
            } while (erro);

            return x;

        }
        //Override de requisitarOpcao para caso não haja limite de opções
        public static int requisitarInteiro(String mensagem)
        {
            bool erro = false;

            int x = 0; // Inicializa x com 0 para evitar erros de referência antes da atribuição

            do
            {//Loop para garantir que o usuário digite um número válido
                try
                {
                    erro = false; // Reseta o erro para false a cada iteração
                    Console.WriteLine(mensagem);
                    x = int.Parse(Console.ReadLine());

                }
                catch (FormatException e1)
                {
                    erro = true; // Se ocorrer um erro de formato, define erro como true para repetir o loop
                    Console.WriteLine("Erro: {0}. Por favor, digite um número válido.", "Formato inválido");
                }
                
                catch (Exception e3)
                {
                    Console.WriteLine("Erro: {0}. Por favor, digite um número válido.", e3.Message);
                }
            } while (erro);

            return x;
        }


        public static double requisitarPreco(String mensagem)
        {
            {
                bool erro = false;

                double x = 0.0; // Inicializa x com 0 para evitar erros de referência antes da atribuição

                do
                {//Loop para garantir que o usuário digite um número válido
                    try
                    {
                        erro = false; // Reseta o erro para false a cada iteração
                        Console.WriteLine(mensagem);
                        x = double.Parse(Console.ReadLine());

                        if (x < 0)
                        {
                            throw new ArgumentOutOfRangeException("Erro: O preço não pode ser negativo");
                        }

                    }
                    catch (FormatException e1)
                    {
                        erro = true; // Se ocorrer um erro de formato, define erro como true para repetir o loop
                        Console.WriteLine("Erro: {0}. Por favor, digite um número válido.", "Formato inválido");
                    }
                    catch (ArgumentOutOfRangeException e2)
                    {
                        erro = true;// Se ocorrer um erro, define erro como true para repetir o loop
                        Console.WriteLine("O preço não pode ser negativo");
                    }

                    catch (Exception e3)
                    {
                        Console.WriteLine("Erro: {0}. Por favor, digite um número válido.", e3.Message);
                    }
                } while (erro);

                return x;
            }
        }


        public static double requisitarDouble(String mensagem)


        {
            bool erro = false;

            double x = 0; // Inicializa x com 0 para evitar erros de referência antes da atribuição

            do
            {//Loop para garantir que o usuário digite um número válido
                try
                {
                    erro = false; // Reseta o erro para false a cada iteração
                    Console.WriteLine(mensagem);
                    x = double.Parse(Console.ReadLine());

                }
                catch (FormatException e1)
                {
                    erro = true; // Se ocorrer um erro de formato, define erro como true para repetir o loop
                    Console.WriteLine("Erro: {0}. Por favor, digite um número válido.", "Formato inválido");
                }
                catch (Exception e2)
                {
                    erro = true;// Se ocorrer um erro, define erro como true para repetir o loop
                    Console.WriteLine("Erro: {0}. Por favor, digite um número válido.", e2.Message);
                }
            } while (erro);

            return x;
        }
        //Override de requisitarDouble para caso haja limite de opções
        public static double requisitarDouble(String mensagem,double min, double max)
        {
            bool erro = false;

            double x = 0; // Inicializa x com 0 para evitar erros de referência antes da atribuição

            do
            {//Loop para garantir que o usuário digite um número válido
                try
                {
                    erro = false; // Reseta o erro para false a cada iteração
                    Console.WriteLine(mensagem);
                    x = double.Parse(Console.ReadLine());

                    if (x < min || x > max)
                    {
                        throw new ArgumentOutOfRangeException($"A opção deve ser entre {min} e {max}.");
                    }

                }
                catch (FormatException e1)
                {
                    erro = true; // Se ocorrer um erro de formato, define erro como true para repetir o loop
                    Console.WriteLine("Erro: {0}. Por favor, digite um número válido.", "Formato inválido");
                }
                catch (ArgumentOutOfRangeException e2)
                {
                    erro = true;// Se ocorrer um erro, define erro como true para repetir o loop
                    Console.WriteLine($"A opção deve ser entre {min} e {max}.");
                }
                catch (Exception e3)
                {
                    erro = true;// Se ocorrer um erro, define erro como true para repetir o loop
                    Console.WriteLine("Erro: {0}. Por favor, digite um número válido.", e3.Message);
                }
            } while (erro);

            return x;
        }


        public static Int64 requisitarNumeroCel(String mensagem)
        {
            bool erro = false;

            Int64 x = 0; // Inicializa x com 0 para evitar erros de referência antes da atribuição

            do
            {//Loop para garantir que o usuário digite um número válido
                try
                {
                    erro = false; // Reseta o erro para false a cada iteração
                    Console.WriteLine(mensagem);
                    x = Int64.Parse(Console.ReadLine());

                    if (Math.Log10(x) < 9 || Math.Log10(x) > 11)
                    {
                        double teste = Math.Log10(x);
                        throw new ArgumentOutOfRangeException("O número de telefone deve ter 10 ou 11 dígitos.");
                    }

                }
                catch (ArgumentOutOfRangeException e2)
                {
                    erro = true; 
                    Console.WriteLine("Erro: {0}. Por favor, digite um número válido.", "O número de telefone deve ter 10 ou 11 dígitos.");
                }
                catch (FormatException e1)
                {
                    erro = true; // Se ocorrer um erro de formato, define erro como true para repetir o loop
                    Console.WriteLine("Erro: {0}. Por favor, digite um número válido.", "Formato inválido");
                }

                catch (Exception e3)
                {
                    Console.WriteLine("Erro: {0}. Por favor, digite um número válido.", e3.Message);
                }
            } while (erro);

            return x;
        }

        public static string requisitarEmail(String mensagem) { 
        string x = null;

            bool erro = false;
            do
            {//Loop para garantir que o usuário digite um email válido
                try
                {
                    erro = false; // Reseta o erro para false a cada iteração
                    Console.WriteLine(mensagem);
                    x = Console.ReadLine();
                    if (!x.Contains("@") || !x.Contains("."))
                    {
                        throw new FormatException("O email deve conter '@' e '.'");
                    }
                }
                catch (FormatException e1)
                {
                    erro = true; // Se ocorrer um erro de formato, define erro como true para repetir o loop
                    Console.WriteLine("Erro: {0}. Por favor, digite um email válido.", "O email deve conter '@' e '.'");
                }
                catch (Exception e2)
                {
                    Console.WriteLine("Erro: {0}. Por favor, digite um email válido.", e2.Message);
                }
            } while (erro);
            return x;


        }
    }
}

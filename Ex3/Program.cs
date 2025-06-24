using Ex3.models;

namespace Ex3;

class Program
{
    public static void Main(String[] args)
    {
        {
            double a, b;
            int escolha;

            a = RequisitarDouble("Digite o primeiro número(!Use a vírgula para separar a parte decimal!): ");
            b = RequisitarDouble("Digite o segundo número!Use a vírgula para separar a parte decimal!: ");

            MostrarOpcoes();

            escolha = RequisitarOperacao("Digite o número da operação desejada: ");

            double resultado = CalcularResultado(escolha, a, b);

            if (!double.IsNaN(resultado)) // Verifica se o resultado é válido (não é NaN)
            {
                MostrarResultado(resultado);
            }
        }

    }
    static double RequisitarDouble(String mensagem)
    {
        bool erro = false;

        double x = 0; // Inicializa x com 0 para evitar erros de referência antes da atribuição

        do{
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

    static int RequisitarOperacao(String mensagem)
    {
        bool erro = false;

        int x = 0; // Inicializa x com 0 para evitar erros de referência antes da atribuição

        do
        {//Loop para garantir que o usuário digite um número válido
            try
            {
                erro = false; // Reseta o erro para false a cada iteração
                Console.WriteLine(mensagem);
                x =int.Parse(Console.ReadLine());

                if(x < 1 || x > 4)
                {
                    throw new ArgumentOutOfRangeException("A opção deve ser entre 1 e 4.");
                }
            }catch(FormatException e1)
            {
                erro = true; // Se ocorrer um erro de formato, define erro como true para repetir o loop
                Console.WriteLine("Erro: {0}. Por favor, digite um número válido.", "Formato inválido");
            }
            catch (ArgumentOutOfRangeException e2)
            {
                erro = true;// Se ocorrer um erro, define erro como true para repetir o loop
                Console.WriteLine("Erro: {0}. Por favor, digite um número válido.", "A opção deve ser entre 1 e 4.");
            } catch (Exception e3)
            {
                Console.WriteLine("Erro: {0}. Por favor, digite um número válido.", e3.Message);
            }
        } while (erro);

        return x;
    }

    static void MostrarOpcoes()
    {
        Console.WriteLine("Escolha uma operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
    }

    static void MostrarResultado(double resultado)
    {
        Console.WriteLine("O resultado da operação é: " + resultado);
    }

    static double CalcularResultado(int escolha, double a, double b)
    {
        double resultado = 0;
        switch (escolha)
        {
            case 1:
                return resultado = Calculadora.Soma(a, b);
                
            case 2:
                return resultado = Calculadora.Subtracao(a, b);
                
            case 3:
                return resultado = Calculadora.Multiplicacao(a, b);
                
            case 4:
                try
                {
                    resultado = Calculadora.Divisao(a, b);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Impossível dividir por 0");
                    return double.NaN; // Retorna NaN para indicar erro
                }
                break;
        }

        return resultado;
    }

}
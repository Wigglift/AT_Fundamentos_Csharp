namespace Exer12;


using Exer12.models;

class Program
{
    public static void Main(string[] args)
    {
        bool sair = false;

        Console.WriteLine("Se for a primeira vez executando esse programa, altere a variável path em ListaDeContatos.cs para adicionar o caminho do arquivo .txt");

        do
        {
            MostrarMenu();

            int opcao = Usuario.RequisitarInteiro("Escolha uma opção: ", 1, 3);
            switch (opcao)
            {
                case 1:
                    ListaDeContatos.InserirContato(MontarContato());
                    break;
                case 2:
                    ListaDeContatos.ListarContatos();
                    break;
                case 3:
                    sair = true;
                    break;
            }
        } while (!sair);
        do
        {

        } while (sair = false);

        Console.WriteLine("\nObrigado por usar o sistema de contatos! Até logo!");
    }

    public static void MostrarMenu()
    {
        Console.WriteLine("\n==Gerenciador de Contatos==\n");

        Console.WriteLine("1. Adicionar novo contato");
        Console.WriteLine("2. Listar contatos cadastrados");
        Console.WriteLine("3. Sair");
    }

    public static Contato MontarContato()
    {
        Console.WriteLine("\nDigite o nome do contato:");
        string nome = Console.ReadLine();

        Int64 telefone = Usuario.RequisitarNumeroCel("\nDigite o telefone do contato (formato: 11912345678): ");

        string email = Usuario.RequisitarEmail("\nDigite o email do contato: ");

        return new Contato(nome, telefone.ToString(), email);

    }
}
using Ex2.models;

namespace Ex2;

class Program
{
    public static void Main(String[] args)
    {

        Console.WriteLine("Digite seu nome");
        string nome = Console.ReadLine();

        Cifrador cifrador = new Cifrador(nome);

        Console.WriteLine("Seu nome cifrado é {0}", cifrador.Cifrar());
    }
}
namespace Ex10;

using Exer10.models;

class Program
{
    public static void Main(string[] args)
    {
        int vidas = 5;
        int userNum = 0;
        bool acertou = false;

        int numero = new Random().Next(1, 51);


        do
        {

            userNum = Usuario.requisitarInteiro($"Insira um número 1 a 50 ({vidas} vidas restante)", 1, 50);

            if (userNum == numero)
            {
                acertou = true;
                Console.WriteLine("Parabéns, você acertou!");
                break;
            }
            else if (userNum > numero)
            {
                vidas--;
                Console.WriteLine("O número é menor que o informado.");
            }
            else
            {
                vidas--;
                Console.WriteLine("O número é maior que o informado.");
            }


        } while (vidas > 0);

        if (!acertou)
        {
            Console.WriteLine($"Você perdeu, o número era {numero}");
        }
        else
        {
            Console.WriteLine($"Você acertou o número {numero} com {vidas} vidas restantes.");
        }
    }
}
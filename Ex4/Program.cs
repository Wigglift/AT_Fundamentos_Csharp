namespace Ex4;

using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main(string[] args)
    {
        DateTime Data_nasc = pegarData();

        apresentarProxDias(proxAniversario(Data_nasc));
    }
    static DateTime pegarData()
    {
        bool erro = false;
        do
        {
            // Loop para garantir que a data seja válida
            try
            {
                erro = false;
                Console.WriteLine("Digite a data de nascimento no formado dd/mm/aaaa");
                DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                //Verifica se a data fornecida não está no futuro

                if (data.Year > DateTime.Today.Year) 
                {
                    throw new ArgumentOutOfRangeException("O ano da data de nascimento não pode ser maior que o ano atual.");
                }else if (data.Year == DateTime.Today.Year && data.Month > DateTime.Today.Month)
                {
                    throw new ArgumentOutOfRangeException("O mês da data de nascimento não pode ser maior que o mês atual do ano atual.");
                }else if (data.Year == DateTime.Today.Year && data.Month == DateTime.Today.Month && data.Day > DateTime.Today.Day)
                {
                    throw new ArgumentOutOfRangeException("O dia da data de nascimento não pode ser maior que o dia atual do mês atual do ano atual.");
                }

                    return data;

            }catch(FormatException ex)
            {
                erro = true; // Se ocorrer um erro de formato, define erro como true para repetir o loop
                Console.Error.WriteLine("Formato inválido. Por favor, digite a data no formato correto (dd/mm/aaaa).\n");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                erro = true; // Se ocorrer um erro de intervalo, define erro como true para repetir o loop
                Console.Error.WriteLine(ex.Message + "\n");
            }
            catch (Exception ex)
            {
                erro = true; // Se ocorrer um erro, define erro como true para repetir o loop
                Console.Error.WriteLine("Digite a data no formato certo e com informações válidas\n");
            }
        } while (erro);

        return DateTime.MinValue; // Retorna um valor padrão para possibilitar a compilação do código;
    }

    static int proxAniversario(DateTime data)
    {
        // Calcula o próximo aniversário com base na data de nascimento fornecida

        int prox_ano = DateTime.Today.Year + 1;// Define o próximo ano para garantir que o próximo aniversário seja calculado corretamente

        Calendar cal = new GregorianCalendar();// Cria uma instância do calendário gregoriano para manipulação de datas

        DateTime prox_niver = new DateTime(prox_ano, data.Month, data.Day);// Cria uma nova data para o próximo aniversário com base no mês e dia da data de nascimento fornecida, mas no próximo ano

        DateTime data_atual = DateTime.Today;


        TimeSpan dias = prox_niver - data_atual;// Calcula a diferença em dias entre o próximo aniversário e a data atual

        if (dias.TotalDays > cal.GetDaysInYear(data_atual.Year))//Caso a diferença seja maior que o número de dias no ano atual, significa que o próximo aniversário será nesse ano
        {
            prox_niver = new DateTime(data_atual.Year, data.Month, data.Day);// Cria uma nova data para o próximo aniversário com base no ano atual e refaz o cálculo da diferença em dias

            dias = prox_niver - data_atual;
        }


            return (int)dias.TotalDays;
        }

    static void apresentarProxDias(int dias)
    {
        if (dias <8) Console.WriteLine("Falta menos de 1 semana para seu aniversário!");
        else Console.WriteLine("Faltam {0} dias para o seu aniversário!", dias);
    }
}
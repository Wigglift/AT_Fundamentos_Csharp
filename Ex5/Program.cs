﻿using System.Globalization;

namespace Ex5;

public class Program
{
    static DateTime formatura = new DateTime(2029,04,07); // Data da formatura
    public static void Main(String[] args)
    {

        DateTime dataAtual = PegarData(); // Pega a data atual do usuário

        ApresentarProxDias(DiferencaData(formatura, dataAtual)); // Calcula e apresenta a diferença entre a data da formatura e a data atual
    }

    static DateTime PegarData()
    {
        bool erro = false;
        do
        {
            // Loop para garantir que a data seja válida
            try
            {
                erro = false;
                Console.WriteLine("Digite a data atual no formato dd/mm/aaaa");
                DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (data.Year > DateTime.Today.Year)
                {
                    throw new ArgumentOutOfRangeException("O ano da data atual não pode ser maior que o ano atual.");
                }
                else if (data.Year == DateTime.Today.Year && data.Month > DateTime.Today.Month)
                {
                    throw new ArgumentOutOfRangeException("O mês da data atual não pode ser maior que o mês atual do ano atual.");
                }
                else if (data.Year == DateTime.Today.Year && data.Month == DateTime.Today.Month && data.Day > DateTime.Today.Day)
                {
                    throw new ArgumentOutOfRangeException("O dia da data atual não pode ser maior que o dia atual do mês atual do ano atual.");
                }
            
                return data;

            }
            catch (FormatException)
            {
                erro = true; // Se ocorrer um erro de formato, define erro como true para repetir o loop
                Console.Error.WriteLine("Formato inválido. Por favor, digite a data no formato correto (dd/mm/aaaa).\n");
            }
            catch (ArgumentOutOfRangeException)
            {
                erro = true; // Se ocorrer um erro de intervalo, define erro como true para repetir o loop
                Console.Error.WriteLine("Erro: A data informada não pode ser no futuro!");
            }
            catch (Exception)
            {
                erro = true; // Se ocorrer um erro, define erro como true para repetir o loop
                Console.Error.WriteLine("Digite a data no formato certo e com informações válidas\n");
            }
        } while (erro);

        return DateTime.MinValue; // Retorna um valor padrão para possibilitar a compilação do código;
    }

    public static int[] DiferencaData(DateTime data1, DateTime data2)

    {

        int[] diferencaDatasArray = new int[3]; // Array para armazenar anos, meses e dias de diferença entre as datas

        TimeSpan timeDifference = (data1 - data2);

        if(timeDifference < TimeSpan.Zero)
        {
            return diferencaDatasArray; // Retorna um array vazio se a diferença for negativa
        }

        Calendar cal = new GregorianCalendar(); // Cria uma instância do calendário gregoriano para manipulação de datas

        if (timeDifference.TotalDays > (cal.GetDaysInYear(2029) + DateTime.DaysInMonth(0001, 1)))
        {

            //preparando a variável de dias para somar com o datetime, como ele começa 01/01/0001 para ter a diferença exata precisamos tirar esses dias do total

            TimeSpan add_span = TimeSpan.FromDays(timeDifference.TotalDays - cal.GetDaysInYear(formatura.Year));

            DateTime diferencaDataFormatada = new DateTime().AddDays(add_span.TotalDays);

            diferencaDatasArray[0] = diferencaDataFormatada.Year;
            diferencaDatasArray[1] = diferencaDataFormatada.Month;
            diferencaDatasArray[2] = diferencaDataFormatada.Day;

        }
        else
        {
            // Calcula a diferença entre as datas em anos, meses e dias
            int diasNoMesAtual = DateTime.DaysInMonth(data2.Year, data2.Month);
                
            int anos = (data1.Year - data2.Year);
            int meses = (data1.Month - data2.Month);
            int dias = (data1.Day - data2.Day);

            if (meses < 0)
            {
                anos--; // Reduz o ano se os meses forem negativos
                meses += 12; // Ajusta o mês para a quantia de meses corretas caso os meses sejam negativos e falte menos de 1 ano
            }

            if (dias < 0)
            {
                dias += diasNoMesAtual; // Ajusta os dias para ser positivo
                meses--; // Reduz o mês se os dias forem negativos
            }

            //atribuído número das datas para um array
            //o tipo DateTime padrão vem como 01/01/0001 e não aceita datas menores
            //por isso o timespan geraria problemas para demonstrar datas com 0 de diferença entre elas

            anos = anos < 0 ? 0 : anos; // Garante que anos não seja negativo

            diferencaDatasArray[0] = anos;
            diferencaDatasArray[1] = meses;
            diferencaDatasArray[2] = dias;


        }

        return diferencaDatasArray;
        }

    static void ApresentarProxDias(int[] diasRestantes)
    {
        // Apresenta a diferença entre as datas em anos, meses e dias

        if (diasRestantes[0] == 0 && diasRestantes[1] == 0 && diasRestantes[2] == 0)
        {
            Console.WriteLine("Você já está formado!");

        }
        else if (diasRestantes[0] == 0 && diasRestantes[1] < 6)
        {
            Console.WriteLine("Faltam {0} anos, {1} meses e {2} dias para a formatura!", diasRestantes[0], diasRestantes[1], diasRestantes[2]);
            Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
        }
        else
        {
            Console.WriteLine("Faltam {0} anos, {1} meses e {2} dias para a formatura!", diasRestantes[0], diasRestantes[1], diasRestantes[2]);
        }
            
    }
    } 
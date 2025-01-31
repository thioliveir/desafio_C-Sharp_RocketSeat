namespace DateNow;
class Program
{
    static void Main()
    {
        // Obter a data atual no sistema
        DateTime now = DateTime.Now;

        // Exigir a data e hora completa (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)
        string completeData = now.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss");
        Console.WriteLine("Formato Completo da data: " + completeData);

        // Exibir apenas a data no formato "DD/MM/YYYY"
        string resumedData = now.ToString("dd/MM/yyyy");
        Console.WriteLine("Formato resumido: " + resumedData);

        // Exibir apenas a hora no formato de 24 horas (hh:mm)
        string timeOnly = now.ToString("HH:mm");
        Console.WriteLine("Formato em Horas e Minutos: " + timeOnly);

        // Exibir a data com o mês por extenso (Dia de Mês de Ano)
        string mounth = now.ToString("dd 'de' MMMM 'de' yyyy");
        Console.WriteLine("Formato mês por extenso: " + mounth);
    }
}

using System.ComponentModel;

namespace CaracterNumber;
class Program
{
    static void Main()
    {
        Console.Write("Digite uma ou mais palavras (separadas por espaços): ");
        string input = Console.ReadLine();

        // Iniciando um contador de caracteres
        int contador = 0;

        foreach (char c in input)
        {
            if(c != ' ')
            {
                contador++;
            }
        }

        Console.WriteLine($"A quantidade de caracter na frase é: {contador}");
        
    }
}

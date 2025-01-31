namespace Welcome;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que digita seu nome
        Console.Write("Digite seu nome: ");

        // Lê o nome digitado e armazena na variável
        string nome = Console.ReadLine();

        // Exige a tela de boas-vindas com o nome do usuário
        Console.WriteLine("Olá, " + nome + "! Seja muito bem-vindo!");
    }
}

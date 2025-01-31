namespace NameLastname;
class Program
{
    static void Main()
    {
        Console.Write("Digite o seu nome: ");
        string name = Console.ReadLine();

        Console.Write("Digite o seu sobrenome: ");
        string lastname = Console.ReadLine();

        Console.WriteLine("O seu nome completo é: " + name + " " + lastname);
    }
}
namespace OperacoesMatematicas;
class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite outro numero: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        Operacoes calculo = new Operacoes();

        Console.WriteLine("Soma: " + calculo.Somar(number1, number2));
        Console.WriteLine("Subtração: " + calculo.Subtrair(number1, number2));
        Console.WriteLine("Multiplicação: " + calculo.Multiplica(number1, number2));
        Console.WriteLine("Divisão: " + calculo.Divide(number1, number2));
        Console.WriteLine("A média entre eles é: " + calculo.Media(number1, number2));


    }
}
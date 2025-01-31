namespace PlateVehicle;
class Program
{
    static void Main()
    {
        // Solicita ao usuário para digitar a placa do veículo
        Console.Write("Digite a placa de um veículo: ");
        string placa = Console.ReadLine();

        //Verificar se a placa tem 7 caracteres
        if (placa.Length == 7 )
        {
            // Verifica se os 3 primeiros caracteres são letras e os 4 últimos são números
            if (Char.IsLetter(placa[0]) && Char.IsLetter(placa[1]) && Char.IsLetter(placa[2]) &&
                Char.IsDigit(placa[3]) && Char.IsDigit(placa[4]) && Char.IsDigit(placa[5]) && Char.IsDigit(placa[6]))
            {
                Console.WriteLine("Verdadeiro");
            } else
            {
                Console.WriteLine("Falso");
            }
        } else
        {
            // Se o comprimento da placa nao for 7, é invalidada
            Console.WriteLine("A placa não contém 7 caracteres, quantidade padrão");
        }
    }
}

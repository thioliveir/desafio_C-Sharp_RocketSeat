using System.ComponentModel.Design;
using System.Diagnostics;

namespace OperacoesMatematicas;

public class Operacoes
{
    public double Somar(double number1, double number2)
    {
        return number1 + number2;
    }
    public double Subtrair(double number1, double number2)
    {
        if(number1 > number2)
        {
            return number1 - number2;
        } else
        {
            return number2 - number1;
        }
    }
    public double Multiplica(double number1, double number2)
    {
        return (number1 * number2);
    }
    public double Divide(double number1, double number2)
    {
        if(number1 > number2 && number1 != 0 && number2 != 0)
        {
            return number1 / number2;
        } else if (number2 > number1 && number1 != 0 && number2 != 0)
        {
            return number2 / number1;
        }

        return 0;
        
    }
    public double Media(double number1, double number2)
    {
        double media = (number1 + number2) / 2;

        return media;

    }
}

namespace aula_operadores;

public class Program
{
    public static void Main()
    {
        //operadores aritméticos

        int number1 = 1;
        int number2 = 2;
        int multiplication = number1 * number2;
        int divison = number1 / number2;
        int restodedivison = number1 % number2;

        int soma = number1 + number2;
        Console.WriteLine("o valor total é " + soma);
        Console.WriteLine("o valor da multiplicação é " + multiplication);
        Console.WriteLine("o valor da divisão é " + divison);
        Console.WriteLine("O resto da divison de 1 com 2 é " + restodedivison);

    }
}
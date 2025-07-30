namespace condicao;

public class Program
{
    public static void Main()
    {
        // aqui vai ter todo a estrutura condicional
        Console.WriteLine("Bem vindo a base de cadastro");
        string name = "maria";
        int idade = 18;
        bool ativo = false;

        if( ativo == true)
        {
            if (name == "maria" && idade == 18) ;
            { Console.WriteLine("cliente está presente na base de dados");      }
        } else
        {
            Console.WriteLine("cliente nãp está na base de dados");
        }

        //verificador de par ou impar

        Console.WriteLine("digite um numero: ");
        int par = Convert.ToInt32(Console.ReadLine());

        int res = par % 2;

        if (res == 0) {
        Console.WriteLine("o numero " + par + " é par ");
        
        }else
        {
            Console.WriteLine("o numero " + par + " é impar ");
        }


    }

}
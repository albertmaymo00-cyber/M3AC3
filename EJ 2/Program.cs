internal class Program
{
    private static void Main(string[] args)
    {

        int numero1, numero2;

        Console.WriteLine("escribe un numero");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("escribe otro numero");
        numero2 = Convert.ToInt32(Console.ReadLine());

        if (numero1 < numero2)
        {
            Console.WriteLine("el numero2 es mayor");
        }

        else if (numero1 > numero2)

            Console.WriteLine("el numero1 es mayor");


        else
            Console.WriteLine("son iguales");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        int edad;
        Console.WriteLine("Ingrese su edad: ");
        edad = Convert.ToInt32(Console.ReadLine());

        if (edad <= 13)
        {
            Console.WriteLine("Niño");
        }
        else if (edad > 13 && edad <= 17)
        {
            Console.WriteLine("Adolescente");
        }
        else if (edad >= 18 && edad <= 64)
        {
            Console.WriteLine("Adulto");
        }
        else
        {
            Console.WriteLine("Mayor");
        }
    }
}   
    

// Menor de 13 → “Niño” De 13 a 17 → “Adolescente” De 18 a 64 → “Adulto” 65 o más → “Mayor” 
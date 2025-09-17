
class Program
{
    static void Main()
    {
        Console.Write("Ingrese el número a descomponer: ");
        int numero = int.Parse(Console.ReadLine());
        int original = numero;
        string factores = "";

        for (int i = 2; i <= numero; i++)
        {
            while (numero % i == 0)
            {
                factores += i + " x ";
                numero /= i;
            }
        }

        if (factores.EndsWith(" x "))
            factores = factores.Substring(0, factores.Length - 3);

        Console.WriteLine($"{original} = {factores}");
    }
}
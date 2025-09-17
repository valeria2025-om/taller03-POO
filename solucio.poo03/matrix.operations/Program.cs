class Program1 
{
    static void Main()
    {
        Console.Write("Ingrese orden de la matriz: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, n];
        int suma = 0;
        int maximo = int.MinValue;
        int minimo = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = (i + 1) - j;
                Console.Write(matriz[i, j] + "\t");

                suma += matriz[i, j];
                if (matriz[i, j] > maximo) maximo = matriz[i, j];
                if (matriz[i, j] < minimo) minimo = matriz[i, j];
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nLa sumatoria es: " + suma);
        Console.WriteLine("El valor máximo es: " + maximo);
        Console.WriteLine("El valor mínimo es: " + minimo);
    }
}

 

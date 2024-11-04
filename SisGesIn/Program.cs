using System;

class Program
{
    static void Main()
    {
        int n = 30; // Cambia este valor para probar
        Console.WriteLine($"El {n}-ésimo número de Fibonacci es: {Fibonacci(n)}");
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        return Fibonacci(n - 1) + Fibonacci(n - 2); // Llamadas recursivas ineficientes
    }
}

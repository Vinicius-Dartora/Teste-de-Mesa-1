using System;

public class Program
{
    public static void Main()
    {
        int[] v = new int[6];
        int b = 20;
        int a = 2;

        while (a < 6)
        {
            int c = (a + b) / 2;
            c = c - 40;

            v[a] = a + b + c;

            a += 1;
        }

        Console.WriteLine("Valores finais no vetor:");
        Console.WriteLine($"Posição v[2]: {v[2]}");
        Console.WriteLine($"Posição v[3]: {v[3]}");
        Console.WriteLine($"Posição v[4]: {v[4]}");
        Console.WriteLine($"Posição v[5]: {v[5]}");
    }
}
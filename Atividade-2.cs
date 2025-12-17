using System;

public class Program
{
    public static void Main()
    {
        int a = 2;
        int[] v = new int[6];

        Console.WriteLine("a\t| v[a]\t| a++\t| a<6");
        Console.WriteLine("----------------------------------------");
        while (a < 6)

        {
            v[a] = 10 * a;

            int valor = a;
            int guardado = v[a];
            int prox = a + 1;
            bool condicao = a < 6;

            Console.WriteLine($"{valor}\t|{guardado}\t|{prox}\t|{condicao}");

            a += 1;
        }

    }
}
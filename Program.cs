using System;

public class Program
{
    public static void Main()
    {
        int a = 9;
        int b = 20;
        int c = (a + b) / 2;
        c = c - 40;
        int[] v = new int[6];

        v[3] = a + b + c;

        if (v[3] == 5)
        {
            Console.WriteLine($"O resultado final é: {v[3]}, nesse caso o resultado é VERDADEIRO");
        }

        else
       {
            Console.WriteLine($"O resultado final é: {v[3]} nesse caso o resultado é FALSO");
        }

    }
}
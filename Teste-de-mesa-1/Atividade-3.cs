using System;

public class Program
{
    public static void Main()
    {
        int a = 7;
        int j = a - 6;
        int b = a - 6;
        int[] v = new int[10];

        Console.WriteLine($"{"a"}   |{"b= a-6",-6} |{"b=b+2",-6} | {"v[i]",-6}| {"v[b]=b+a",-6} | {"b<a",-6}");
        Console.WriteLine("---------------------------------------------");
        while (b <= a)


        {
            int imp = b;
            v[imp] = b + a;
            int contador = b = b + 2;

            int valor = a;
            int valor2 = b;
            int valor3 = contador;
            bool condicao = b < a;
            int t = b - 2;

            Console.WriteLine($"{valor,-4}|{j,-7}|{valor2,-7}|{t,-7}|{v[imp],-10}|{condicao}");


        }
    }
}
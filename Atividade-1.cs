using System;

public class Program
{
    public static void Main()
    {
        int a = 10;
        int b = 20;
        int c = (a + b) / 2;
        int d = c - 40;
        int[] v = new int[6];
        v[3] = 5;

        Console.WriteLine($" {"a",-4} | {"b",-4} | {"c=((a+b)/2)",-10} | {"c=c-40",-4} | {"v(i)",-4} | {"v[i]",-4} | {"v[i]==5",-4}  |");
        Console.WriteLine("--------------------------------------------------------------");

        int i = 0;
        bool t = false;
        while (t == false && i < 6)

        {
            bool condicao = (v[i] == 5);


            Console.WriteLine($" {a,-5}|{b,-6}|{c,-12} |{d,-7} |{i,-5} |{v[i],-6}| {condicao}");

            if (condicao == true)

            {
                t = true;
            }

            i++;
        }
    }
}
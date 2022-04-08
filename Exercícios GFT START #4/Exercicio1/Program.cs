using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b, c;

        Console.Write("Digite o primeiro valor: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Digite o primeiro valor: ");
        b = int.Parse(Console.ReadLine());

        Console.Write("Digite o primeiro valor: ");
        c = int.Parse(Console.ReadLine());

        Console.WriteLine("Ordem de entrada: " + a + b + c);

        if (a < b)
        {
            if (b < c)
            {
                Console.WriteLine("Ordem crescente: " + a + b + c);
            }
            else
            {
                if (a < c)
                {
                    Console.WriteLine("Ordem crescente: " + a + c + b);
                }
                else
                {
                    Console.WriteLine("Ordem crescente: " + c + a + b);
                }
            }
        }
        else
        {
            if (b < c)
            {
                if (a < c)
                {
                    Console.WriteLine("Ordem crescente: " + b + a + c);
                }
                else
                {
                    Console.WriteLine("Ordem crescente: " + b + c + a);
                }
            }
            else
            {
                Console.WriteLine("Ordem crescente: " + c + b + a);
            }
        }

        if (a > b)
        {
            if (b > c)
            {
                Console.WriteLine("Ordem decrescente: " + a + b + c);
            }
            else
            {
                if (a > c)
                {
                    Console.WriteLine("Ordem decrescente: " + a + c + b);
                }
                else
                {
                    Console.WriteLine("Ordem decrescente: " + c + a + b);
                }
            }
        }
        else
        {
            if (b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("Ordem decrescente: " + b + a + c);
                }
                else
                {
                    Console.WriteLine("Ordem decrescente: " + b + c + a);
                }
            }
            else
            {
                Console.WriteLine("Ordem decrescente: " + c + b + a);
            }
        }
    }
}












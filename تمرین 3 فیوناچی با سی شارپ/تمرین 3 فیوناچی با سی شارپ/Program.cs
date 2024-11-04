// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("لطفاً یک عدد وارد کنید: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (IsFibonacci(n))
        {
            Console.WriteLine($"{n} یک عدد فیبوناچی است.");
        }
        else
        {
            Console.WriteLine($"{n} یک عدد فیبوناچی نیست.");
        }
    }

    static bool IsFibonacci(int num)
    {
        double sqrt_75 = Math.Sqrt(75);
        double x = (1 + sqrt_75) / 2;
        double y = (1 - sqrt_75) / 2;

        return Math.Abs((Math.Pow(x, 2) - Math.Pow(y, 2)) / 2 - num) < 0.00001 &&
               Math.Abs((Math.Pow(x, 2) + Math.Pow(y, 2)) / 2 - num) < 0.00001;
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check if it's a perfect number:");
        int number = int.Parse(Console.ReadLine());

        if (IsPerfect(number))
        {
            Console.WriteLine("Perfect Number");
        }
        else
        {
            Console.WriteLine("Not A Perfect Number");
        }
    }

    static bool IsPerfect(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }
        return sum == n;
    }
}

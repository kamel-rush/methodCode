using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This is my first C# program
// To DO:

class HelloClass
{
    static void Main(string[] args)
    {
        // PrintOneToTen();
        int max = int.Parse(Console.ReadLine());

        int min = int.Parse(Console.ReadLine());
        //PrintNumbers(max);

        // int result = SumOneToTen();

        //int result = sum(20, 50);

        int result = sum(min, max);

        Console.WriteLine(result);


    }

    static void PrintOneToTen()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

    }

    static void PrintNumbers(int Max)
    {
        for (int i = 1; i <= Max; i++)
        {
            Console.WriteLine(i);
        }
    }

    static int SumOneToTen()
    {
        int sum = 0;

        for (int i = 1; i <= 10; i++)
        {
            sum = sum + i;
        }
        return sum;
    }

    static int sum(int num1, int num2)
    {
        int sum1 = 0;
        for (int i = num1; i <= num2; i++)
        {
            sum1 = sum1 + i;
        }
        return sum1;
    }

}


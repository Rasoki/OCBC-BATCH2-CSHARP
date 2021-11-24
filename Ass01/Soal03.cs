using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CobaSoal03 
{
    static void Main(string[] args)
    {
        int h;
        Console.Write("Enter any number: ");
        int n = int.Parse(Console.In.ReadLine());
        h = 1;

        for (int i=1; i<=n; i++)
        {
            h = h*i;

            
        }
        Console.Write("Factorial of " + n + " is : ");

        Console.WriteLine(h);
        Console.ReadLine();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Soal02{
     static void Main(string[] args)
     {
        Console.Write("Masukkan Angka: ");
        String input = Console.ReadLine();

        int n = Convert.ToInt32(input);

        for(int i=0; i<n; i++)
        {
            int c=1;
            for(int j= 0; j<n-i; j++)
            {
                Console.Write(" ");
            }

            for(int k=0; k<=i; k++)
            {
                Console.Write(" {0:D}", c);
                
                c = c*(i-k) / (k+1);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
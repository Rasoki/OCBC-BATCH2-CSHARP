using System;

class Soal05{
     public static string Terbilang(int x)
        {
             
                string[] bilangan = {"", "one", "two", "three", "four", "five","six", "seven", "eight", "nine"};
                string temp = "";
                 
                    if (x < 12)
                    {
                        temp = " " + bilangan[x];
                    }
                    else if (x < 20)
                    {
                        temp =  Terbilang(x / 10) + Terbilang(x % 10) ;
                    }
                    else if (x < 100)
                    {
                        temp = Terbilang(x / 10) + Terbilang(x % 10);
                    }
                    else if (x < 200)
                    {
                        temp =  Terbilang(x / 100) +  Terbilang(x % 100);
                    }
                    else if (x < 1000)
                    {
                        temp = Terbilang(x / 100) +  Terbilang(x % 100);
                    }
                    else if (x < 2000)
                    {
                        temp =  Terbilang(x / 1000) + Terbilang(x % 1000);
                    }
                    else if (x < 1000000)
                    {
                        temp = Terbilang(x / 1000) + Terbilang(x % 1000);
                    }
                    return temp;
        }
        public static void Main(string[] args)
        {
            int a;
            Console.Write("masukkan nilai : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Terbilang(a));
            Console.ReadKey(true);
        }
    }

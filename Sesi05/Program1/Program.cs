using System;

namespace Program1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //instant objek
            Laptop laptop1 = new Laptop();

            //akses atribut
            laptop1.merk="lenovo";
            laptop1.ram=4;
            laptop1.memory=128;

            //Tampilkan
            Console.WriteLine("\nMerk Laptop adalah ");
            laptop1.merk = Console.ReadLine();
            Console.WriteLine("Kapasitas Ram ada ");
            laptop1.ram = int.Parse(Console.ReadLine());
            Console.WriteLine("Kapasitas Memory ada ");
            laptop1.memory = int.Parse(Console.ReadLine());


            //Akses Method
            laptop1.Chatting();
            laptop1.Sosmed();
            laptop1.OnlineShop();

            Console.Read();
        }
    }
}

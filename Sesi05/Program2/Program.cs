using System;

namespace Program2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pesawat pesawat = new Pesawat();
            pesawat.nama = "GARUDAKU";
            pesawat.ketinggian = "2500 kaki";

            pesawat.terbang();
            pesawat.sudahterbang();
            Console.Read();
        }
    }
}

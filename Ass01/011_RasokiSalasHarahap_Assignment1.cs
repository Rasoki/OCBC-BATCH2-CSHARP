using System;

class Final_Assignment{
public static void Main(string[] args) {

string repeat = "N", input = "";

do {
    Console.WriteLine("\n Assignment 1 \n\n Nama : RASOKI SALAS HARAHAP \n No.Peserta: FSDO002ONL011 \n Alamat: BOGOR");
    Console.WriteLine("");

    Console.WriteLine("===Daftar Soal===");
    Console.WriteLine("");
    Console.WriteLine(" 1. Segitiga Alphabet \n 2. Segitiga Angka \n 3. Faktorial \n 4. Balik Angka \n 5. Converter Angka dengan String");
    
    Console.WriteLine("");
    Console.WriteLine("Masukkan angka: ");
    input = Console.ReadLine();

    switch (input)
    {
        case "1":{
             Console.WriteLine("Anda memilih Segitiga Alphabet");
        Console.WriteLine("");

        int height;
        string dictionary = "ABCDEF";

        Console.Write($"enter the height : ");
        height = int.Parse(Console.ReadLine());

        for(int i=0; i <= height; i++){
            for(int j=0; j < height - i; j++) {
                Console.Write(" ");
            }

             for(int j=0; j < i; j++) {
                Console.Write(dictionary[j]);
            }

            for(int k=i -2 ; k >= 0; k--) {
                Console.Write(dictionary[k]);
            }
             Console.WriteLine(" ");
        }
        Console.WriteLine(" ");
        break;}
        case "2":{
            Console.WriteLine("Anda memilih Segitiga Angka");
        Console.WriteLine("");

        int height;
        

        Console.Write($"enter the range : ");
        height = int.Parse(Console.ReadLine());

        for(int i=0; i <= height; i++){
            for(int j=0; j < height - i; j++) {
                Console.Write(" ");
            }

             for(int j=1; j < i; j++) {
                Console.Write(j);
            }

            for(int k=i -2 ; k >= 1; k--) {
                Console.Write(k);
            }
             Console.WriteLine(" ");
        }
        Console.WriteLine(" ");
        break;}
        case "3":{
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
        break;}
        case "4":{
        string masukkan = "", reverseStr = "";

    Console.Write("enter a number : ");
    masukkan = Console.ReadLine();

    for(int i = masukkan.Length - 1; i >= 0; i --) {
        reverseStr += masukkan[i];
    }

    Console.WriteLine($"Reversed Number : {reverseStr}");
    break;}
        case "5":{

           break;}
        default:{
        Console.WriteLine("Kosong");
        break;}
    }
    Console.Write("Kembali ke menu awal ? Y/N :");
    repeat = Console.ReadLine();
    repeat = repeat.ToUpper();
} while(repeat == "Y");

}
}
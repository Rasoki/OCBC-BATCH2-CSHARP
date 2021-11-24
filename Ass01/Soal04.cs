using System;

class Soal04 {
    public static void Main(string[] args) {
         string masukkan = "", reverseStr = "";

    Console.Write("enter a number : ");
    masukkan = Console.ReadLine();

    for(int i = masukkan.Length - 1; i >= 0; i --) {
        reverseStr += masukkan[i];
    }

    Console.WriteLine($"Reversed Number : {reverseStr}");
    }
}
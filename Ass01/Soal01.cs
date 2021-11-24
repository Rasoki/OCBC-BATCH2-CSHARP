using System;

class Soal01{

public static void Main(string[] args){
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
}
}
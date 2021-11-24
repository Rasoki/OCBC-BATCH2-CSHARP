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
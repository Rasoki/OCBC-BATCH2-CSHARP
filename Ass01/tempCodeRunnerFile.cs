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
                        temp =  Terbilang(x - 1000);
                    }
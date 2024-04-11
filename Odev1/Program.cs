using System;

namespace odev1{

    class Odev1{


        static void Main(string[] args){

            /*
            
            Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            */


            


            Console.Write("Lütfen bir sayı girin:");

            int n = Convert.ToInt32(Console.ReadLine());

            if(n>0){


            int[] sayiUzunlugu = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Lütfen {0}.sayiyi girin:",i+1);
                sayiUzunlugu[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Çift Sayılar:");

            for (int i = 0; i < n; i++)
            {
                 if(sayiUzunlugu[i]%2==0){

                    Console.WriteLine(sayiUzunlugu[i]);
                }
            }
            
            }

            else{

                Console.WriteLine("Lütfen pozitif bir sayı girin!");
            }


        



            /*

            Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın

            */


        


            Console.Write("Lütfen ilk sayıyı girin:");

            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen ikinci sayıyı girin:");

            int m = Convert.ToInt32(Console.ReadLine());

            int[] sayiListesi = new int[n1];

            for (int i = 0; i < n1; i++)
            {
                Console.Write("Lütfen {0}.sayıyı gir:",i+1);
                sayiListesi[i] = Convert.ToInt32(Console.ReadLine()); 

            }


             for (int i = 0; i < n1; i++)
                    {

                        if(sayiListesi[i] == m || sayiListesi[i] % m == 0){

                             Console.WriteLine(sayiListesi[i]);

                        }
                       
                    }



                    




         /*

        
        Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
        Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
        Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.


        */


        


        Console.Write("Lütfen sayıyı girin:");

        int n2 = Convert.ToInt32(Console.ReadLine());

        string[] kelimeListesi = new string[n2];

        for (int i = 0; i < n2; i++)
        {
            Console.Write("Lütfen {0}.kelimeyi girin:",i+1);
            kelimeListesi[i] = Console.ReadLine();
        }

        Array.Reverse(kelimeListesi);


        foreach (var kelime in kelimeListesi)
        {
         
         Console.WriteLine(kelime);
        }

        



        /*

        Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
        Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

        */


			Console.WriteLine("Bir cümle yazınız:");

			string cumle = Console.ReadLine();

			string[] kelimeler_dizi = cumle.Split(' ');

			Console.WriteLine("Kelime sayısı: "+ kelimeler_dizi.Length);

			int space = cumle.Count(char.IsWhiteSpace);

			int char_count = cumle.Length - space;

			Console.WriteLine("Harf sayısı: " + char_count);

			Console.ReadKey();


















                
            


































            }
        }
    }

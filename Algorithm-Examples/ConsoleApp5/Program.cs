using System;

namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Girilen string ifadenin içinde bulunan sayıları toplama.
            TotalNumber totalNumber = new TotalNumber();
            Console.WriteLine("İçinde bulunan sayıların toplanmasını istediğini string bir değer giriniz");
            string letter=Console.ReadLine();
            Console.WriteLine($" Girilen değer içindeki sayıların toplamı = {totalNumber.TotalNumberCalculator(letter)}") ;
            //Girilen bir metinsel ifadenin içinde bulunan küçük harfli karakterleri büyük,büyük harfli karakterleri ise küçük yapan ve kelime içinde 2 tane sayı varsa yerlerini değiştiren program
            StringChallange stringChallange = new StringChallange();
            Console.WriteLine("Bir cümle yazınız");
            string letter2=Console.ReadLine();
            Console.WriteLine($" Girilen metinsel ifadenin içinde bulunan küçük harfli karakterleri büyük,büyük harfli karakterleri ise küçük yapıldı ve 2 sayı varsa yerleri değiştirildi ====>>>>> {stringChallange.StringChallengeMethod(letter2)}");
        }

    }
}

using System;
using System.Linq;

namespace _11._04_Ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Klavyeden 2adet sayı girişi yapalım.
            Sadece sayı girişi kabul edelim.
            1 ile 100 arası sayısı girişi yapılabilsin. 1 ve 100 dahil.
            İki sayının da toplama işlemi yapılabilir durumda olsun.
            */
            Console.WriteLine("Lütfen 1 ile 100 arasında bir sayı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 1 ile 100 arasında bir sayı daha giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());
            if (Enumerable.Range(1, 100).Contains(sayi1) && Enumerable.Range(1, 100).Contains(sayi2))
                Console.WriteLine("Verdiğiniz sayıların toplamı: {0}", sayi1 + sayi2);
            else
                Console.WriteLine("Girdiğiniz sayılar kabul edilmedi.");

        }
    }
}

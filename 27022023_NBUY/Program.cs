using System;
using System.ComponentModel.Design;

namespace _27022023_NBUY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region kullanıcınınkelimesini5kereyazdırma
            /*string kelime;
            Console.WriteLine("Yazdırmak İstediğiniz Mesajı Girin:");
            kelime = Console.ReadLine();

            Console.WriteLine("Kelime Yazdırılıyor..");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(kelime);
            }*/
            #endregion

            #region kullanıcıkelimesiniistediğikadaryazdırma
            /*string kelime;
            int tekrar;
            Console.WriteLine("Yazdırmak İstediğiniz Mesajı Girin:");
            kelime = Console.ReadLine();
            Console.WriteLine("Kac Adet Yazdırmak İstiyorsunuz:");
            tekrar = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Kelime Yazdırılıyor..");

            for (int i = 0; i < tekrar; i++)
            {
                Console.WriteLine(kelime);
            }*/
            #endregion

            #region 1-100arasındaciftsayılarıyazdırma
            /*for (int i = 2; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/
            #endregion

            #region kullanıcıaralıgındaki3ebolunenleriyazdırma
            /*int ilkdeger, ikincideger;
            Console.WriteLine("İlk Sayıyı Girin:");
            ilkdeger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı Girin:");
            ikincideger = Convert.ToInt32(Console.ReadLine());

            for (int i = ilkdeger; i < ikincideger; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            } */
            #endregion

            #region 1-10arasısayılarıntoplamı
            /*int toplam = 0;

            for (int i = 1; i <= 10; i++)
            {
                toplam += i;
            }
            Console.WriteLine(toplam);*/
            #endregion

            #region kullacısayılarındancıftlerınortalamasıbulma
            /*int toplam=0,adet=0,ort;

            Console.WriteLine("İlk sayı küçük olan");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayı büyük olan");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            for (int i=sayi1;i<sayi2;i++)
            {
                if (sayi1 % 2 == 0)
                {
                    Toplam += i;
                    adet = adet + 1;
                }
            }
            Console.WriteLine("******************");
            Console.WriteLine(Toplam / adet);*/
            #endregion


            #region 5ve5tenbüyüksayılarıntoplamortalaması
            /*int toplam = 0, adet = 0, ort;

            Console.WriteLine("ilk degeri girin");
            int sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("ikinci değeri girin");
            int sayi2 = Convert.ToInt16(Console.ReadLine());

            for (int i = sayi1; i < sayi2; i++)
            {
                if (i >= 5 && i % 10 >= 5) ;

                {
                    toplam = toplam + i;
                    adet = adet + 1;
                }
            }
            ort = toplam / adet;
            Console.WriteLine(ort);*/
            #endregion

            #region KullanıcınınGirdiği10sayındanEnKucukveEnbuyukBulma
            /*int kucuk, buyuk, sayi;
            Console.WriteLine("10Sayıgirin");
            int y = Convert.ToInt32(Console.ReadLine());
            kucuk = y;
            buyuk = y;


            for (int i = 0; i < 9; i++)
            {
                sayi = Convert.ToInt32(Console.ReadLine());

                if (buyuk < sayi)
                {
                    buyuk = sayi;
                }
                if (kucuk > sayi)
                {
                    kucuk = sayi;
                }
            }
            Console.WriteLine("kucuk sayi" + " " + kucuk);
            Console.WriteLine("buyuk sayi" + " " + buyuk);*/
            #endregion

            #region çiftlerinkaresitoplamı,teklerinküpütoplamı
            /*int number_1, number_2;
            int joker;
            Console.Write("bir sayı gir:");
            number_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("bir sayı gir:");
            number_2 = Convert.ToInt32(Console.ReadLine());

            int even_pieces = 0, odd_pieces = 0;
            int even_square = 0, odd_cube = 0;

            if (number_1 > number_2)
            {
                joker = number_2;
                number_2 = number_1;
                number_1 = joker;
            }
            for (int i = number_1; i <= number_2; i++)
            {
                if (i % 2 == 0)
                {
                    even_pieces++;
                    even_square += i * i;
                }
                else
                {
                    odd_pieces++;
                    odd_cube += i * i * i;
                }
            }
            Console.WriteLine($"çift adedi:{even_pieces} çiftlerin karesi toplam:{even_square}\n" +
                $"tek adedi:{odd_pieces} teklerin küpü toplam:{odd_cube}");*/
            #endregion


        }
    }
}

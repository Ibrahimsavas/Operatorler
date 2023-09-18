using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aritmetiksel Operatörler
            ////Toplama +
            ////Çıkarma -
            ////Çarpma *
            ////Bölme /
            ////Aatama =
            ////Tanımlanan değişkene veri atamak için kullanınılır.
            ////Özel operatörler
            ////+=, -=, *=, /=, ++, --


            //int sayi1 = 13;
            //int sayi2 = 5;
            //int toplam = sayi1 + sayi2;
            //Console.Write("Toplam = ");
            //Console.WriteLine(toplam);

            ////sayi1 den sayi2 yi çıkar fark isimli değişkene at
            //int fark = sayi1 - sayi2;
            //Console.Write("Fark = ");
            //Console.WriteLine(fark);

            //int carpim = sayi1 * sayi2;
            //Console.Write("Çarpım = ");
            //Console.WriteLine(carpim);

            ////Bölme işleminin ondalık sonuç vermesini istiyorsak. Bölme işleminde kullanılan değişkenlerin double, float veya decimal olması gerekir.

            //double sayi3 = 13;
            //double sayi4 = 5;


            //double bolum = sayi3 / sayi4;
            //Console.Write("Bölüm = ");
            //Console.WriteLine(bolum);

            ////Mod = iki sayını birbirine bölümünden kalan
            //int mod = sayi1 % sayi2;
            //Console.Write("Mod = ");
            //Console.WriteLine(mod);


            //Console.WriteLine(sayi1);
            //sayi1 += 10;
            //Console.WriteLine(sayi1);

            //sayi1++;//sayi 1 in değerini 1 arttır
            //Console.WriteLine(sayi1);


            #endregion

            #region Karşılaştırma öperatörleri

            //Karşılaştırma operatörleri her zaman boolean veri döndürür
            int sayi = 22;

            Console.Write("Sayı 10 dan büyük mü = ");
            Console.WriteLine(sayi > 10);
            Console.Write("Sayı 10 dan küçük mü = ");
            Console.WriteLine(sayi < 10);
            Console.Write("Sayı 10 a eşit mi = ");
            Console.WriteLine(sayi == 10);

            #endregion
        }
    }
}

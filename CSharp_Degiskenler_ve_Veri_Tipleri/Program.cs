using System;

namespace CSharp_Degiskenler_ve_Veri_Tipleri
{
    class Program
    {
        static void Main(string[] args)  //Veri Tipleri
        {
            // Tam sayı veri tipleri
            byte byteDeger = 255;          // 8-bit işaretsiz tam sayı
            short shortDeger = 32767;      // 16-bit işaretli tam sayı
            int intDeger = 2147483647;     // 32-bit işaretli tam sayı
            long longDeger = 9223372036854775807;  // 64-bit işaretli tam sayı

            // Ondalık sayı veri tipleri
            float floatDeger = 3.14f;      // 32-bit ondalık sayı
            double doubleDeger = 3.141592653589793; // 64-bit ondalık sayı
            decimal decimalDeger = 3.14159265358979323846m; // 128-bit ondalık sayı

            // Mantıksal veri tipi
            bool boolDeger = true;         // true veya false

            // Karakter veri tipi
            char charDeger = 'A';          // Tek bir karakter

            // Metin (dizgi) veri tipi
            string stringDeger = "Merhaba, Dünya!";  // Metin dizisi

            // Tarih ve saat veri tipi
            DateTime dateTimeDeger = DateTime.Now;   // Geçerli tarih ve saat

            // Nesne referansı
            object objDeger = new object();  // Her türden nesnenin referansını tutar

            // Değerleri ekrana yazdırma
            Console.WriteLine("Byte Değeri: " + byteDeger);
            Console.WriteLine("Short Değeri: " + shortDeger);
            Console.WriteLine("Int Değeri: " + intDeger);
            Console.WriteLine("Long Değeri: " + longDeger);
            Console.WriteLine("Float Değeri: " + floatDeger);
            Console.WriteLine("Double Değeri: " + doubleDeger);
            Console.WriteLine("Decimal Değeri: " + decimalDeger);
            Console.WriteLine("Bool Değeri: " + boolDeger);
            Console.WriteLine("Char Değeri: " + charDeger);
            Console.WriteLine("String Değeri: " + stringDeger);
            Console.WriteLine("DateTime Değeri: " + dateTimeDeger);
            Console.WriteLine("Object Değeri: " + objDeger);
        }
    }
}

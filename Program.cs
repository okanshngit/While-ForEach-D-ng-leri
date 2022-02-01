using System;

namespace While_ForEach_Döngüleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ortalaması alınacak sayıyı sonunu giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac=1;
            int toplam=0;

            while (sayac<=sayi)
            {
                toplam=toplam+sayac;
                sayac++;
            }
            Console.WriteLine("Ortalama: "+toplam/sayi);
        }
    }
}

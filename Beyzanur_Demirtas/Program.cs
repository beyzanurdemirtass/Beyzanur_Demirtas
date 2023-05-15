using System;
    using System.Threading;
namespace Beyzanur_Demirtas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Rezervasyon Uygulaması";

            Console.WriteLine("Bilet Rezervasyon Uygulamasına Hoşgeldin.\n");

            YolcuOlusturma yolcuOlusturma = new YolcuOlusturma();
            Yolcu yolcu = yolcuOlusturma.yolcu();

            Rezervasyon biletOlusturma = new(yolcu.İsim, yolcu.Soyisim);
            Console.Write(biletOlusturma.UcusDondur());

            Console.Write("\n\n Güzel Yolculuklar Dilerim.");

            Thread.Sleep(10000000);
        }
    }






}




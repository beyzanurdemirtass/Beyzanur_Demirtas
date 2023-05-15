using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beyzanur_Demirtas
{
    internal class YolcuOlusturma
    {
        public string İsim { get; set; }

        public string Soyisim { get; set; }

        public string DoğumTarihi { get; set; }

        public string TcNo { get; set; }

        public string Telefon { get; set; }

        public int Cinsiyet { get; set; }

        public int Engel { get; set; }

        public Yolcu yolcu()
        {
            Console.Write("İsminizi Giriniz: ");
            İsim = Console.ReadLine();

            Console.Write("Soyisminizi Giriniz: ");
            Soyisim = Console.ReadLine();

            Console.Write("DoğumTarihi Giriniz: ");
            DoğumTarihi = Console.ReadLine();

            Console.Write("TcNo Giriniz: ");
            TcNo = Console.ReadLine();

            Console.Write("Telefonunuzu Giriniz: ");
            Telefon = Console.ReadLine();

            while (true)
            {
                string Temp = string.Empty;

                Console.Write("Cinsiyetinizi Giriniz(E/K): ");
                Temp = Console.ReadLine();

                if (Temp == "E")
                {
                    Cinsiyet = 1;
                    break;
                }
                else if (Temp == "K")
                {
                    Cinsiyet = 2;
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Değer");
                }
            }

            while (true)
            {
                string Temp = string.Empty;

                Console.Write("Engel Durumunuz Var mı?(E/H): ");
                Temp = Console.ReadLine();

                if (Temp == "E")
                {
                    Engel = 1;
                    break;
                }
                else if (Temp == "H")
                {
                    Engel = 2;
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Değer");
                }
            }

            Yolcu yolcu = new Yolcu(İsim, Soyisim, DoğumTarihi, TcNo, Telefon, Cinsiyet, Engel);

            return yolcu;
        }
    }
}


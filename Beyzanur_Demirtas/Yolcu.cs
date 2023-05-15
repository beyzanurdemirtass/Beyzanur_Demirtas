using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beyzanur_Demirtas
{
    internal class Yolcu
    {
        public string İsim { get; set; }

        public string Soyisim { get; set; }

        public string DoğumTarihi { get; set; }

        public string TcNo { get; set; }

        public string Telefon { get; set; }

        public int Cinsiyet { get; set; }

        public int Engel { get; set; }

        public Yolcu(string isim, string soyisim, string dt, string tcNo, string telefon, int cinsiyet, int engel)
        {
            İsim = isim;
            Soyisim = soyisim;
            Cinsiyet = cinsiyet;
            DoğumTarihi = dt;
            TcNo = tcNo;
            Telefon = telefon;
            Engel = engel;
        }
    }
}

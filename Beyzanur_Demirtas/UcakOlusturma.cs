using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Beyzanur_Demirtas
{
    internal class UcakOlusturma : Ucak
    {
        public string Model { get; set; }

        public string SeriNo { get; set; }

        public int KacKisilik { get; set; }

        public string Motor { get; set; }
        int Ucak.SeriNo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int Ucak.Motor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private Random Random = new Random();

        public UcakOlusturma()
        {
            int random = Random.Next(0, 3);

            switch (random)
            {
                case 0:
                    Model = "AIRBUS A220";
                    SeriNo = " CS100 ";
                    KacKisilik = 108 - 133;
                    Motor = "PW1500G";
                    break;
                case 1:
                    Model = "BAC1-11";
                    SeriNo = " CRC";
                    KacKisilik = 89;
                    Motor = "RB.163 SPEY MK506";
                    break;
                case 2:
                    Model = "AIRBUS A300";
                    SeriNo = " A300 B2K-3C ";
                    KacKisilik = 266;
                    Motor = "CF6-50 C2";
                    break;
                case 3:
                    Model = "DASSAULT MERCURE";
                    SeriNo = "CS300";
                    KacKisilik = 162;
                    Motor = "JT8D-15 MK.527 TURBOFAN";
                    break;
                default:
                    break;
            }
        }

    }
}

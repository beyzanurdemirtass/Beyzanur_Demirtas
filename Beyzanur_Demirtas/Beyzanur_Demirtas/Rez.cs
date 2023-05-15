using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beyzanur_Demirtas
{
    internal class Rez
    {
        public int fiyat;

        Random random = new Random();

        public Rez()
        {
            fiyat = Convert.ToInt32(random.Next(100, 2000));
        }
    }
}

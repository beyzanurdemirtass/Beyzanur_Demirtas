using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beyzanur_Demirtas
{
    internal interface Ucak
    {
        public string Model { get; set; }

        public int SeriNo { get; set; }

        public int KacKisilik { get; set; }

        public int Motor { get; set; }
    }
}

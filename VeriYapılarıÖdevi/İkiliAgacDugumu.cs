using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapılarıÖdevi
{
    public class İkiliAgacDugumu
    {
        public object veri;
        public İkiliAgacDugumu sol;
        public İkiliAgacDugumu sag;
        public İkiliAgacDugumu(object veri)
        {
            this.veri = veri;
            sol = null;
            sag = null;
        }
    }
}

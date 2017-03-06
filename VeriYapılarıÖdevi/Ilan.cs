using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapılarıÖdevi
{
    public class Ilan
    {
        public string IsTanimi { get; set; }
        public string ElemanOzellik { get; set; }
        public int IlanNo { get; set; }

        public Heap basvuranlar;

        public Ilan()
        {
            basvuranlar = new Heap(10);
            IlanNo = Math.Abs(Guid.NewGuid().GetHashCode());
        }
    }
}

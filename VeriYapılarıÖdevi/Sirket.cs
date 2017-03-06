using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapılarıÖdevi
{
    public class Sirket
    {
        
        public string SirketAd { get; set; }
        public string SirketAdres { get; set; }
        public int SirketTel { get; set; }
        public int SirketFaks { get; set; }
        public string SirketEposta { get; set; }
        
        public Ilan ilan = new Ilan();
    }
}

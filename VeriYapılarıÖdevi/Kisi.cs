using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapılarıÖdevi
{
    public class Kisi
    {
        public string PersonelAd { get; set; }
        public string PersonelAdres { get; set; }
        public int PersonelTel{ get; set; }
        public string KisiEposta { get; set; }
        public string Uyruk { get; set; }
        public string DogumYeri { get; set; }
        public int DogumTarihi { get; set; }
        public string MedeniDurumu { get; set; }
        public string YabanciDil { get; set; }
        public string IlgiAlanlari { get; set; }
        public string Referanslar { get; set; }
        public double Uygunluk { get; set; }
        public LinkedList<IsDeneyimi> deneyim = new LinkedList<IsDeneyimi>();
        public LinkedList<EgitimDurumu> egitim = new LinkedList<EgitimDurumu>();
    }
}

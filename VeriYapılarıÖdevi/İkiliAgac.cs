using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapılarıÖdevi
{
    public class İkiliAgac
    {
        private İkiliAgacDugumu kok;
        public string dugumler;
        public List<Kisi> liste = new List<Kisi>();
        public İkiliAgac()
        {
            kok = null;
        }
        //Kok private olduğu için overloaded DugumSayisi fonksiyonu
        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }


        public void Insert(object Value)
        {
            insertRoot(Value, ref kok);
        }
        private void insertRoot(object Value, ref İkiliAgacDugumu LastNode)
        {
            if (LastNode == null)
                LastNode = new İkiliAgacDugumu(Value);
            else
            {
                int CompareTo = String.Compare(((Kisi)Value).PersonelAd, ((Kisi)LastNode.veri).PersonelAd);
                if (CompareTo == 0) return;

                if (CompareTo < 0)
                    insertRoot(Value, ref LastNode.sol);
                else
                    insertRoot(Value, ref LastNode.sag);
            }
        }


        public İkiliAgacDugumu Search(string Name)
        {
            İkiliAgacDugumu nextNode = kok;
            int CompareTo;

            while (nextNode != null)
            {
                CompareTo = String.Compare(Name, ((Kisi)nextNode.veri).PersonelAd);
                if (CompareTo == 0) //Bulundu
                    return nextNode;

                if (CompareTo < 0)
                    nextNode = nextNode.sol;
                else
                    nextNode = nextNode.sag;
            }
            return null;
        }



        public int DugumSayisi (İkiliAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol);
                count += DugumSayisi(dugum.sag);
            }
            return count;
        }
        public int YaprakSayisi()
        {
            return YaprakSayisi(kok);
        }
        public int YaprakSayisi(İkiliAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                if ((dugum.sol == null) && (dugum.sag == null))
                    count = 1;
                else
                    count = count + YaprakSayisi(dugum.sol) + YaprakSayisi(dugum.sag); 
            }
            return count;
        }
        public List<Kisi> KisileriYazdir()
        {
            return liste;
        }
        public string DugumleriYazdir()
        {
            return dugumler;
        }
        //Gezinme İşlemleri
        public void PreOrder()
        {
            liste = new List<Kisi>();

            dugumler = "";
            PreOrderInt(kok);
        }
        private void PreOrderInt(İkiliAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }
        public void InOrder()
        {
            liste = new List<Kisi>();

            dugumler = "";
            InOrderInt(kok);
        }
        private void InOrderInt(İkiliAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }
        private void Ziyaret(İkiliAgacDugumu dugum)
        {
            liste.Add(((Kisi)dugum.veri));
            dugumler += ((Kisi)dugum.veri).PersonelAd + "\n";
        }
        public void PostOrder()
        {
            liste = new List<Kisi>();
            dugumler = "";
            PostOrderInt(kok);
        }
        private void PostOrderInt(İkiliAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
        }
    }
}

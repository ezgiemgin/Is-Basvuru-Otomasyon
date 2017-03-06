using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace VeriYapılarıÖdevi
{
    public partial class frm_girisTur : Form
    {
        public frm_girisTur()
        {
            InitializeComponent();
        }
        public static HashMapChain Sirketler = new HashMapChain();
        public static İkiliAgac Kisiler = new İkiliAgac();
        public static List<int> IlanID = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            SirketForm sfrm = new SirketForm();
            sfrm.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kisi_Bilgileri kisifrm = new Kisi_Bilgileri();
            kisifrm.Show();
            this.Hide();
        }

        private void btnElemanlariOku_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("elemanlar.txt"))
            {
                Kisi_Bilgileri.kisi = new Kisi();
                Kisi_Bilgileri.kisi.PersonelAd = sr.ReadLine();
                Kisi_Bilgileri.kisi.KisiEposta = sr.ReadLine();
                Kisi_Bilgileri.kisi.YabanciDil = sr.ReadLine();
                Kisi_Bilgileri.kisi.Referanslar = sr.ReadLine();
                Kisi_Bilgileri.kisi.egitim.AddFirst(new EgitimDurumu { Ortalama = Convert.ToInt32(sr.ReadLine()) });
            }
                Button b = new Button();
                Form a = new Kisi_Bilgileri();
                a.Show();
                this.Hide();
                foreach (var item in a.Controls)
                {
                    if (((Control)item).Name == "txt_KisiAd")
                        ((Control)item).Text = Kisi_Bilgileri.kisi.PersonelAd;
                    if (((Control)item).Name == "txt_Ortalama")
                        ((Control)item).Text = Kisi_Bilgileri.kisi.egitim.Last.Value.Ortalama.ToString();
                    if (((Control)item).Name == "txt_Dil")
                        ((Control)item).Text = Kisi_Bilgileri.kisi.YabanciDil;
                    if (((Control)item).Name == "txt_Referans")
                        ((Control)item).Text = Kisi_Bilgileri.kisi.Referanslar;
                    if (((Control)item).Name == "txt_KisiPosta")
                        ((Control)item).Text = Kisi_Bilgileri.kisi.KisiEposta;
                    if (((Control)item).Name == "btn_Kaydet")
                        b = ((Button)item);


                }
                b.PerformClick();

            
            //using (StreamWriter sw = new StreamWriter("elemanlar.txt"))
            //{
            //    sw.WriteLine(frm_girisTur.Kisiler.DugumleriYazdir());
            //}
        }

        private void frm_girisTur_Load(object sender, EventArgs e)
        {

        }

        private void btnSirketOku_Click(object sender, EventArgs e)
        {
            
            SirketForm.sirket = new Sirket();
            using(StreamReader sr = new StreamReader("sirketler.txt"))
	        {
                SirketForm.sirket.SirketAd = sr.ReadLine();
                SirketForm.sirket.SirketTel = Convert.ToInt32(sr.ReadLine());
                SirketForm.sirket.SirketFaks = Convert.ToInt32(sr.ReadLine());
                SirketForm.sirket.SirketEposta= sr.ReadLine();
                SirketForm.sirket.SirketAdres = sr.ReadLine();
                
	        }    
            
            
            Button b = new Button();
            Form a = new SirketForm();

            a.Show();
            this.Hide();
            foreach (var item in a.Controls)
            {
                if (((Control)item).Name == "txt_sirketAdi")
                {
                    ((Control)item).Text = SirketForm.sirket.SirketAd;
                }
                if (((Control)item).Name == "txt_sirketTel")
                {
                    ((Control)item).Text = SirketForm.sirket.SirketTel.ToString();
                }
                if (((Control)item).Name == "txt_sirketFaks")
                {
                    ((Control)item).Text = SirketForm.sirket.SirketFaks.ToString();
                }
                if (((Control)item).Name == "txt_sirketMail")
                {
                    ((Control)item).Text = SirketForm.sirket.SirketEposta;
                }
                if (((Control)item).Name == "txt_sirketAdres")
                    ((Control)item).Text = SirketForm.sirket.SirketAdres;
                
                if (((Control)item).Name == "btn_sirketKaydet")
                    b = ((Button)item);
            }
            b.PerformClick();
            //using (StreamWriter sw = new StreamWriter("sirketler.txt"))
            //{
            //    foreach (var item in frm_girisTur.IlanID)
            //    {
            //        sw.WriteLine(((Sirket)frm_girisTur.Sirketler.GetIlan(item)).SirketAd);
            //    }
            //}
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Kisi)Kisiler.Search(txt_arama.Text).veri).PersonelAd + "\n" +
                            ((Kisi)Kisiler.Search(txt_arama.Text).veri).egitim.Last.Value.Ortalama.ToString() + "\n" +
                            ((Kisi)Kisiler.Search(txt_arama.Text).veri).YabanciDil + "\n" +
                            ((Kisi)Kisiler.Search(txt_arama.Text).veri).Referanslar + "\n" +
                            ((Kisi)Kisiler.Search(txt_arama.Text).veri).KisiEposta );
        }

        private void btn_90ustu_Click(object sender, EventArgs e)
        {
            foreach (Kisi item in Kisiler.liste)
            {
                if (item.egitim.Last.Value.Ortalama>=90)
                {
                    MessageBox.Show(item.PersonelAd);
                }
            }
        }

        private void btn_ingilizce_Click(object sender, EventArgs e)
        {
            foreach (Kisi item in Kisiler.liste)
            {
                if (item.YabanciDil.ToLower() == "ingilizce")
                {
                    MessageBox.Show(item.PersonelAd);
                }
            }
        }

        private void btn_inorder_Click(object sender, EventArgs e)
        {
            Kisiler.InOrder();
            MessageBox.Show(Kisiler.dugumler);
        }

        private void btn_preorder_Click(object sender, EventArgs e)
        {
            Kisiler.PreOrder();
            MessageBox.Show(Kisiler.dugumler);
        }

        private void btn_postorder_Click(object sender, EventArgs e)
        {
            Kisiler.PostOrder();
            MessageBox.Show(Kisiler.dugumler);
        }
    }
}

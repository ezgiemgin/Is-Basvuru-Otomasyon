using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapılarıÖdevi
{
    public partial class Kisi_Bilgileri : Form
    {
        public Kisi_Bilgileri()
        {
            InitializeComponent();
        }

        private void btn_İlanGor_Click(object sender, EventArgs e)
        {
            IsBasvuru isbsvrfrm = new IsBasvuru();
            isbsvrfrm.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public static Kisi kisi;
        private void Kisi_Bilgileri_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[Application.OpenForms.Count - 1].Show();
        }

        private void Kisi_Bilgileri_Load(object sender, EventArgs e)
        {

        }
        Random rnd = new Random(Guid.NewGuid().GetHashCode());
        private void btn_Kaydet_Click(object sender, EventArgs e)
        { 
            kisi= new Kisi();
           
            
            kisi.PersonelAd = txt_KisiAd.Text;
            kisi.Referanslar = txt_Referans.Text;
            kisi.Uygunluk =  Math.Round(rnd.NextDouble()*10 , 2);
            kisi.KisiEposta = txt_KisiPosta.Text;
            kisi.egitim.AddFirst(new EgitimDurumu { Ortalama = Convert.ToInt32(txt_Ortalama.Text) });
            kisi.YabanciDil = txt_Dil.Text;
            MessageBox.Show("Kaydetme İşlemi Başarılı!");

            btn_Guncelle.Enabled = true;
            btn_İlanGor.Enabled = true;
            btn_Sil.Enabled = true;
            frm_girisTur.Kisiler.Insert(kisi);
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            kisi.PersonelAd = txt_KisiAd.Text;
            kisi.Referanslar = txt_Referans.Text;
            kisi.KisiEposta = txt_KisiPosta.Text;
            kisi.YabanciDil = txt_Dil.Text;
            MessageBox.Show("Güncelleme Başarılı!");
        }

       

       

    
    }
}

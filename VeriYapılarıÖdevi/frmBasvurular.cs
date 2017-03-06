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
    public partial class frmBasvurular : Form
    {
        public frmBasvurular()
        {
            InitializeComponent();
            dgv_adayListesi.Columns.Add("Ad", "Ad");
            dgv_adayListesi.Columns.Add("Referans","Referans");
            dgv_adayListesi.Columns.Add("Eposta", "Eposta");
            dgv_adayListesi.Columns.Add("Uygunluk", "Uygunluk");
            dgv_adayListesi.Columns.Add("Yabancı Dil", "Yabancı Dil");

        }

        private void frmBasvurular_Load(object sender, EventArgs e)
        {
            dgv_adayListesi.Rows.Clear();
             foreach (Kisi item in Ilanlar.SecilenSirketIlani.ilan.basvuranlar.DisplayHeap())
                dgv_adayListesi.Rows.Add(item.PersonelAd,item.Referanslar,item.KisiEposta,item.Uygunluk,item.YabanciDil);
            
        }

        private void btn_iseAl_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Seçilen Eleman İşe Alındı!");
            Ilanlar.SecilenSirketIlani.ilan = new Ilan();
            frmBasvurular_Load(null,null);
            MessageBox.Show("İlan Temizlendi.");
        }

        private void frmBasvurular_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[Application.OpenForms.Count - 1].Show();
        }

        private void dgv_adayListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

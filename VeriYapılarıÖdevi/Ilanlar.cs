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
    public partial class Ilanlar : Form
    {
        public Ilanlar()
        {
            InitializeComponent();
            DataGridViewButtonColumn dgvBtn = new DataGridViewButtonColumn();
            dgvBtn.HeaderText = "Başvuranlar";
            dgvBtn.Text = "Getir";
            dgvBtn.UseColumnTextForButtonValue = true;  
            dgv_adayListesi.Columns.Add("Ilan ID", "Ilan ID");
            dgv_adayListesi.Columns.Add("Sirket Adi", "Sirket Adi");
            dgv_adayListesi.Columns.Add("Is Tanimi", "Is Tanimi");
            dgv_adayListesi.Columns.Add("Istenen Ozellikler", "Istenen Ozellikler");
            dgv_adayListesi.Columns.Add(dgvBtn);
        }

        private void btn_ilanver_Click(object sender, EventArgs e)
        {
            IlanVer ilnverfrm = new IlanVer();
            ilnverfrm.Show();
            this.Hide();
        }

        private void Ilanlar_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[Application.OpenForms.Count - 1].Show();
        }
        public static Sirket SecilenSirketIlani;
        private void btn_Listele_Click(object sender, EventArgs e)
        {
            dgv_adayListesi.Rows.Clear();
            

            foreach (var item in frm_girisTur.IlanID)
	        {
                Sirket s = (Sirket)frm_girisTur.Sirketler.GetIlan(item);
                dgv_adayListesi.Rows.Add(s.ilan.IlanNo,s.SirketAd, s.ilan.IsTanimi, s.ilan.ElemanOzellik);
	        }
            
        }
        private void dgv_adayListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SecilenSirketIlani = (Sirket)frm_girisTur.Sirketler.GetIlan((int)dgv_adayListesi.Rows[e.RowIndex].Cells[0].Value);
             if(e.ColumnIndex == 4)
             {
                 Form basvurular = new frmBasvurular();
                 basvurular.Show();
                 this.Hide();
             }

        }

        private void btn_iseAl_Click(object sender, EventArgs e)
        {
            List<object> adaylar = SecilenSirketIlani.ilan.basvuranlar.DisplayHeap();
            double LastUygunluk = 0;
            Kisi tempKisi = new Kisi();
            foreach (Kisi item in adaylar)
            {
                if(LastUygunluk<item.Uygunluk)
                {
                    LastUygunluk = item.Uygunluk;
                    tempKisi = item;
                }
            }
            if (string.IsNullOrEmpty(tempKisi.PersonelAd))
            {
                MessageBox.Show("Yeterli Sayida Eleman Bulunamadi.");
                return;
            }
                
            MessageBox.Show(tempKisi.PersonelAd + " işe alındı.");
            SecilenSirketIlani.ilan = new Ilan();
        }

        private void Ilanlar_Load(object sender, EventArgs e)
        {

        }
    }
}

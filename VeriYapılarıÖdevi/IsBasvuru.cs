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
    public partial class IsBasvuru : Form
    {
        public IsBasvuru()
        {
            InitializeComponent();
            DataGridViewButtonColumn dtgBtn = new DataGridViewButtonColumn();
            dtgBtn.HeaderText = "Başvuru";
            dtgBtn.Text = "Başvur";
            dtgBtn.UseColumnTextForButtonValue = true;  
            dgv_IlanListesi.Columns.Add("Ilan ID", "Ilan ID");
            dgv_IlanListesi.Columns.Add("Sirket Adi", "Sirket Adi");
            dgv_IlanListesi.Columns.Add("Is Tanimi", "Is Tanimi");
            dgv_IlanListesi.Columns.Add("Istenen Ozellikler", "Istenen Ozellikler");
            dgv_IlanListesi.Columns.Add(dtgBtn);
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            dgv_IlanListesi.Rows.Clear();


            foreach (var item in frm_girisTur.IlanID)
            {
                Sirket s = (Sirket)frm_girisTur.Sirketler.GetIlan(item);

                if(!Bul(s.ilan.basvuranlar.DisplayHeap(),Kisi_Bilgileri.kisi.PersonelAd))
                {
                    dgv_IlanListesi.Rows.Add(s.ilan.IlanNo, s.SirketAd, s.ilan.IsTanimi, s.ilan.ElemanOzellik);
                }
                
            }
            
        }

        private bool Bul(List<object> liste,string aranan)
        {
            foreach (Kisi item in liste)
            {
                if (item.PersonelAd == aranan)
                    return true;
            }
            return false;
        }

        private void btn_Basvur_Click(object sender, EventArgs e)
        {

        }

        private void IsBasvuru_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[Application.OpenForms.Count - 1].Show();
        }

        private void IsBasvuru_Load(object sender, EventArgs e)
        {

        }

        private void dgv_IlanListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int ilanID = (int)dgv_IlanListesi.Rows[e.RowIndex].Cells[0].Value;
            ((Sirket)frm_girisTur.Sirketler.GetIlan(ilanID)).ilan.basvuranlar.Insert(Kisi_Bilgileri.kisi);
            MessageBox.Show("İşe Başvuruldu!");
            btn_Listele_Click(null, null);

        }
    }
}

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
    public partial class SirketForm : Form
    {
        
        public SirketForm()
        {
            InitializeComponent();
        }

        private void SirketForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_sirketIlan_Click(object sender, EventArgs e)
        {
            Form ilanlar = new Ilanlar();
            ilanlar.Show();
            this.Hide();
        }
        public static Sirket sirket;
        private void btn_sirketKaydet_Click(object sender, EventArgs e)
        {
            sirket = new VeriYapılarıÖdevi.Sirket();
            sirket.SirketAd = txt_sirketAdi.Text;
            sirket.SirketAdres = txt_sirketAdres.Text;
            sirket.SirketEposta = txt_sirketMail.Text;
            sirket.SirketFaks = Convert.ToInt32(txt_sirketFaks.Text);
            sirket.SirketTel = Convert.ToInt32(txt_sirketTel.Text);
            btn_sirketGuncelle.Enabled = true;
            MessageBox.Show("Şirket Kaydedildi!");
            frm_girisTur.Sirketler.AddIlan(sirket.ilan.IlanNo,sirket);
            frm_girisTur.IlanID.Add(sirket.ilan.IlanNo);
        }

        private void btn_sirketGuncelle_Click(object sender, EventArgs e)
        {
            sirket.SirketAd = txt_sirketAdi.Text;
            sirket.SirketAdres = txt_sirketAdres.Text;
            sirket.SirketEposta = txt_sirketMail.Text;
            sirket.SirketFaks = Convert.ToInt32(txt_sirketFaks.Text);
            sirket.SirketTel = Convert.ToInt32(txt_sirketTel.Text);
            MessageBox.Show("Şirket bilgileri güncellendi!");
        }

        private void SirketForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[Application.OpenForms.Count - 1].Show();
        }

       
    }
}

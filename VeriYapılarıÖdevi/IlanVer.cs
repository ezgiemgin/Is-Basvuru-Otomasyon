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
    public partial class IlanVer : Form
    {
        public IlanVer()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            SirketForm.sirket.ilan.IsTanimi = txt_isTanimi.Text;
            SirketForm.sirket.ilan.ElemanOzellik = txt_arananOzellik.Text;

            MessageBox.Show("İlan başarıyla yayınlandı!");
            IlanVer_FormClosed(sender,null);
        }
        
        private void IlanVer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[Application.OpenForms.Count - 1].Show();
        }

        private void IlanVer_Load(object sender, EventArgs e)
        {

        }
    }
}

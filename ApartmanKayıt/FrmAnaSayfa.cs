using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanKayıt
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmKayitlar kayit = new FrmKayitlar();
            kayit.Show();
            this.Hide();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            FrmBorclar borc = new FrmBorclar();
            borc.Show();
            this.Hide();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            FrmFoto foto = new FrmFoto();
            foto.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            FrmDairelerr daire = new FrmDairelerr();
            daire.Show();
            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Öğrenci Apartı için yapılmış olan kayıt otomasyonudur. DevExpress ve C# kullanılarak yapılmıştır. Kasım- 2020");
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelControl1.Text = System.DateTime.Now.ToLongTimeString();
            labelControl2.Text = System.DateTime.Now.ToLongDateString();
        }
    }
}

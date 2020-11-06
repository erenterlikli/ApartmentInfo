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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(txtKullanıcı.Text=="admin" && txtSifre.Text=="123456")
            {
                FrmAnaSayfa anasayfa = new FrmAnaSayfa();
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını veya şifrenizi yanlış girdiniz, lütfen tekrar deneyin!");
                
            }
        }
    }
}

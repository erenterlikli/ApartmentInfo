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
    public partial class FrmDairelerr : Form
    {
        public FrmDairelerr()
        {
            InitializeComponent();
        }

        public void RenkDegistir()
        {
            Btn1.BackColor = Color.DarkSalmon;
            Btn2.BackColor = Color.DarkSalmon;
            Btn3.BackColor = Color.DarkSalmon;
            Btn4.BackColor = Color.DarkSalmon;
            Btn5.BackColor = Color.DarkSalmon;
            Btn6.BackColor = Color.DarkSalmon;
            Btn7.BackColor = Color.DarkSalmon;
            Btn8.BackColor = Color.DarkSalmon;
            Btn9.BackColor = Color.DarkSalmon;
            Btn10.BackColor = Color.DarkSalmon;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            RenkDegistir();
            Btn1.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Ayşe Yıldız";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            RenkDegistir();
            Btn2.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Mehmet Demir";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            RenkDegistir();
            Btn3.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Ahmet Yılmaz";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            RenkDegistir();
            Btn4.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Ali Kaya";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            RenkDegistir();
            Btn5.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Hasan Karadağ";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            RenkDegistir();
            Btn6.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Hüseyin Öztürk";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            RenkDegistir();
            Btn7.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Fatma Özcan";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            RenkDegistir();
            Btn8.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Özgür Aslan";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            RenkDegistir();
            Btn9.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Aslı Güneş";
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            RenkDegistir();
            Btn10.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Cem Çınar";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa anasayfa = new FrmAnaSayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}

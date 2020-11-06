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
    public partial class FrmDaireler : Form
    {
        public FrmDaireler()
        {
            InitializeComponent();
        }
        private void RenkDegistir()
        {
            Btn1.BackColor = Color.PeachPuff;
            Btn2.BackColor = Color.PeachPuff;
            Btn3.BackColor = Color.PeachPuff;
            Btn4.BackColor = Color.PeachPuff;
            Btn5.BackColor = Color.PeachPuff;
            Btn6.BackColor = Color.PeachPuff;
            Btn7.BackColor = Color.PeachPuff;
            Btn8.BackColor = Color.PeachPuff;
            Btn9.BackColor = Color.PeachPuff;
            Btn10.BackColor = Color.PeachPuff;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            RenkDegistir();
            
           
            lblAdSoyad.Text = "Ayşe Yıldız";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa anasayfa = new FrmAnaSayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void FrmDaireler_Load(object sender, EventArgs e)
        {
            RenkDegistir();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            RenkDegistir();
            Btn2.BackColor = Color.DarkCyan;
            lblAdSoyad.Text = "Murat Kutlu";
        }

        private void Btn1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

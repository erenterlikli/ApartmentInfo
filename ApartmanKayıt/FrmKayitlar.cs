using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ApartmanKayıt
{
    public partial class FrmKayitlar : Form
    {
        public FrmKayitlar()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Data Source=EREN\SQLEXPRESS;Initial Catalog=Apartman;Integrated Security=True");

        private void VerileriGetir()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from kiracilar", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["mail"].ToString());
                ekle.SubItems.Add(oku["daireno"].ToString());
                ekle.SubItems.Add(oku["borc"].ToString());

                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }


        private void BtnDaire_Click(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into kiracilar(ad,soyad,telefon,mail,daireno,borc) values('" + txtAd.Text.ToString() + "','" + txtSoyad.Text.ToString() + "','" + txtTel.Text.ToString() + "','" + txtMail.Text.ToString() + "','" +CmbDaire.Text.ToString()+"','"+ txtBorc.Text.ToString() + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            VerileriGetir();
        }
        int id = 0;
        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete from kiracilar where id= (" + id + ")", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            VerileriGetir();

        }

        private void FrmKayitlar_DoubleClick(object sender, EventArgs e)
        {
         

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtTel.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[4].Text;
            CmbDaire.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtBorc.Text = listView1.SelectedItems[0].SubItems[6].Text;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Update kiracilar set ad='" + txtAd.Text.ToString() + "',soyad='" + txtSoyad.Text.ToString() + "',telefon='" + txtTel.Text.ToString() + "',mail='" + txtMail.Text.ToString() + "',daireno='" + CmbDaire.Text.ToString() + "',borc='"+txtBorc.Text.ToString() + "' where id="+id+" ", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            VerileriGetir();

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Text = " ";
            txtSoyad.Text = " ";
            txtTel.Text = " ";
            txtMail.Text = " ";
            txtBorc.Text = " ";
            CmbDaire.Text = " ";
            txtAra.Text = " ";
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from kiracilar where ad like '%"+txtAra.Text+ "%'", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["mail"].ToString());
                ekle.SubItems.Add(oku["daireno"].ToString());
                ekle.SubItems.Add(oku["borc"].ToString());

                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }

        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa anasayfa = new FrmAnaSayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}

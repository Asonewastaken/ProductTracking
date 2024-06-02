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

namespace UrunTakip
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ASONE;Initial Catalog=DbUrun;uid=sa;pwd=1");

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TblAdmin where KullaniciAdi = @p1 and Sifre = @p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmUrun fr = new frmUrun();
                fr.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifrenizde Hata var.");
            }

        }

        private void lnklblKayitEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKayitEkle frm = new frmKayitEkle();
            frm.ShowDialog();
        }
    }
}

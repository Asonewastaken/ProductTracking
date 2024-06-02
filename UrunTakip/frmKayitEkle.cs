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
    public partial class frmKayitEkle : Form
    {
        public frmKayitEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ASONE;Initial Catalog=DbUrun;uid=sa;pwd=1");

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TblAdmin (KullaniciAdi,Sifre) Values (@p1, @p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kullanıcı Başarıyla Eklendi.");          
        }
    }
}

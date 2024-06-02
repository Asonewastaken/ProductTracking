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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASONE;Initial Catalog=DbUrun;uid=sa;pwd=1");

        void veriGetir()
        {
            SqlCommand komut = new SqlCommand("Select * from TblKategori", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            veriGetir();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TblKategori", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
                dataGridView1.DataSource = dt;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TblKategori (Ad) Values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1",txtKategoriAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategoriniz başarıyla eklendi.");
            baglanti.Open();
            veriGetir();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TblKategori Set Ad = @p1 where ID=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKategoriAd.Text);
            komut.Parameters.AddWithValue("@p2", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori başarıyla güncellendi.");
            veriGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from TblKategori where ID = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery(); // Sorguyu çalıştırır.
            baglanti.Close();
            MessageBox.Show("Kategoriniz başarıyla silindi.");
            veriGetir() ;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TblKategori where Ad = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1",txtKategoriAd.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        
    }
}
// Data Source=ASONE;Initial Catalog=DbUrun;User ID=sa;Trust Server Certificate=True
// Data Source = ASONE; Initial Catalog = DbUrun;uid=sa;pwd=1
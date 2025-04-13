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
    public partial class frmKategoriler : Form
    {
        public frmKategoriler()
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

        private void btnListeleAs_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TblKategori", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
                dataGridView1.DataSource = dt;
        }

        private void btnKaydetAs_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TblKategori (Ad) Values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1",txtKategoriAdAs.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategoriniz başarıyla eklendi.");
            baglanti.Open();
            veriGetir();

            txtIDAs.Text = "";
            txtKategoriAdAs.Text = "";
        }

        private void btnGüncelleAs_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TblKategori Set Ad = @p1 where ID=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKategoriAdAs.Text);
            komut.Parameters.AddWithValue("@p2", txtIDAs.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori başarıyla güncellendi.");
            veriGetir();
        }

        private void btnSilAs_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from TblKategori where ID = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtIDAs.Text);
            komut.ExecuteNonQuery(); // Sorguyu çalıştırır.
            baglanti.Close();
            MessageBox.Show("Kategoriniz başarıyla silindi.");
            veriGetir() ;
        }

        private void btnAraAs_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TblKategori where Ad = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1",txtKategoriAdAs.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        
    }
}
// Data Source=ASONE;Initial Catalog=DbUrun;User ID=sa;Trust Server Certificate=True
// Data Source = ASONE; Initial Catalog = DbUrun;uid=sa;pwd=1
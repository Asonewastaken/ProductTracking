using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UrunTakip
{
    public partial class frmIstatistik : Form
    {
        public frmIstatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASONE;Initial Catalog=DbUrun;uid=sa;pwd=1");

        private void frmIstatistik_Load(object sender, EventArgs e)
        {
            //Toplam Kategori Sayısı
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Count(*) from TblKategori", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) //dr komutun okuma işlemi yaptığı müddetçe
            {
                lblToplamKategori.Text = dr[0].ToString();
            }
            baglanti.Close();

            //Toplam Ürün Sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) from TblUrunler", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblToplamUrun.Text = dr2[0].ToString();
            }
            baglanti.Close();

            //Beyaz Eşya Sayısı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count (*) from TblUrunler where Kategori = (Select ID from TblKategori where Ad = 'Beyaz Eşya')\r\n", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblBeyazEsyaSayisi.Text = dr3[0].ToString();
            }
            baglanti.Close();

            //Küçük Ev Aletleri Sayısı
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select Count (*) from TblUrunler where Kategori = (Select ID from TblKategori where Ad = 'Küçük Ev Aletleri')\r\n", baglanti);
            SqlDataReader dr4 = komut3.ExecuteReader();
            while (dr4.Read())
            {
                lblKuckEvAletiSayisi.Text = dr4[0].ToString();
            }
            baglanti.Close();

            //En yüksek stok sayısına sahip ürün
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select * from TblUrunler where Stok = (Select Max(Stok) from TblUrunler)\r\n", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblMaxStok.Text = dr5["UrunAd"].ToString();
            }
            baglanti.Close();

            //En düşük stok sayısına sahip ürün
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select * from TblUrunler where Stok = (Select Min(Stok) from TblUrunler)\r\n", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblMinStok.Text = dr6["UrunAd"].ToString();
            }
            baglanti.Close();

            //Laptop Kar Oranı
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select Stok * (SatisFiyat - AlisFiyat) from TblUrunler where UrunAd = 'Laptop'", baglanti);
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                lblLaptopKarOrani.Text = dr7[0].ToString() + "₺";
            }
            baglanti.Close();

            //Burada komple bir kategorinin kar oranını hesaplıyoruz.
            //Beyaz Eşya Toplam Kar Oranı
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("Select Sum (Stok*(SatisFiyat - AlisFiyat)) as 'Toplam Stokla Çarpılan Sonuç' from TblUrunler where Kategori = (Select ID from TblKategori where Ad = 'Beyaz Eşya')", baglanti);
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                lblBeyazEsyaToplamKarOrani.Text = dr8[0].ToString() + "₺";
            }
            baglanti.Close();
        }
    }
}

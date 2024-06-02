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
    public partial class frmUrun : Form
    {
        public frmUrun()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ASONE;Initial Catalog=DbUrun;uid=sa;pwd=1");

        //Bu metot Listele butonuna basmadan formu açtığımız gibi karşımıza verileri getirir. Bu metodu her bir işlemden sonra
        //(kaydet, güncelle vs.) çağırıyorum çünkü tabloyu her işlemden sonra güncel olarak karşıma getiriyor.
        void veriGetir()
        {
            SqlCommand komut = new SqlCommand("Select\tUrunId,UrunAd, Stok, AlisFiyat, SatisFiyat, Ad, Kategori from TblUrunler\r\nInner join TblKategori\r\nOn TblUrunler.Kategori = TblKategori.ID", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Kategori"].Visible = false;// Burada tabloda kategori hücresini id olarak görmektense isim
            //olarak görmeyi yeğleyeceğimizden dolayı aslında hem isim hem de id olarak tabloda gösterdik. Ancak kullanıcının 
            //bunu görmemesini sağlamak için bu ifadeyi yazdık.

        }
        private void frmUrun_Load(object sender, EventArgs e)
        {
            veriGetir();
            SqlCommand komut = new SqlCommand("Select * from TblKategori", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "Ad";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = dt;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select\tUrunId,UrunAd, Stok, AlisFiyat, SatisFiyat, Ad, Kategori from TblUrunler\r\nInner join TblKategori\r\nOn TblUrunler.Kategori = TblKategori.ID", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Kategori"].Visible = false; // Burada tabloda kategori hücresini id olarak görmektense isim
            //olarak görmeyi yeğleyeceğimizden dolayı aslında hem isim hem de id olarak tabloda gösterdik. Ancak kullanıcının 
            //bunu görmemesini sağlamak için bu ifadeyi yazdık.

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TblUrunler (UrunAd, Stok, AlisFiyat, SatisFiyat, Kategori)" +
                "values (@p1, @p2, @p3, @p4, @p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtUrunAdi.Text);
            komut.Parameters.AddWithValue("@p2", numericUpDown1.Value);
            komut.Parameters.AddWithValue("@p3", txtAlisFiyat.Text);
            komut.Parameters.AddWithValue("@p4", txtSatisFiyat.Text);
            komut.Parameters.AddWithValue("@p5", comboBox1.SelectedValue);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün kaydı başarıyla gerçekleşti.");
            veriGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from TblUrunler where urunId = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtUrunId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün başarıyla silindi");
            veriGetir();
        }

        // Bu event datagrid üzerindeki bir hücreye tıkladığımızda verileri textboxlara yazma özelliği taşıyor.
        // Burada ToString metoduyla değer ataması yaptım lakin numUpdown ve combobox'ta bir dönüşüm kullanmam
        // gerekiyordu. Num da int bir veriyi string bir şekilde yazdıramayacağım için Parse dönüşümünü kullandım.
        // Combobox'ta ise değer ataması SelectedValue ile yapıldığından atamamı o şekilde yaptım.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUrunAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            numericUpDown1.Value = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtAlisFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSatisFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TblUrunler Set UrunAd = @p1, Stok = @p2, AlisFiyat = @p3," +
                "SatisFiyat = @p4, Kategori = @p5 where UrunId = @p6", baglanti);
            komut.Parameters.AddWithValue("@p1", txtUrunAdi.Text);
            komut.Parameters.AddWithValue("@p2", numericUpDown1.Value);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtAlisFiyat.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtSatisFiyat.Text));
            komut.Parameters.AddWithValue("@p5", comboBox1.SelectedValue);
            komut.Parameters.AddWithValue("@p6", txtUrunId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün başarıyla güncellendi.");
            veriGetir();
        }
    }
}

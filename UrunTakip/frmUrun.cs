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

        private void btnListeleAs_Click(object sender, EventArgs e)
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

        private void btnKaydetAs_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TblUrunler (UrunAd, Stok, AlisFiyat, SatisFiyat, Kategori)" +
                "values (@p1, @p2, @p3, @p4, @p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtUrunAdiAs.Text);
            komut.Parameters.AddWithValue("@p2", numericUpDown1.Value);
            komut.Parameters.AddWithValue("@p3", txtAlisFiyatAs.Text);
            komut.Parameters.AddWithValue("@p4", txtSatisFiyatAs.Text);
            komut.Parameters.AddWithValue("@p5", comboBox1.SelectedValue);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün kaydı başarıyla gerçekleşti.");
            veriGetir();

            txtUrunIdAs.Text = "";
            txtUrunIdAs.Text = "";
        }

        private void btnSilAs_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from TblUrunler where urunId = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtUrunIdAs.Text);
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
            txtUrunIdAs.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUrunAdiAs.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            numericUpDown1.Value = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtAlisFiyatAs.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSatisFiyatAs.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void btnGüncelleAs_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TblUrunler Set UrunAd = @p1, Stok = @p2, AlisFiyat = @p3," +
                "SatisFiyat = @p4, Kategori = @p5 where UrunId = @p6", baglanti);
            komut.Parameters.AddWithValue("@p1", txtUrunAdiAs.Text);
            komut.Parameters.AddWithValue("@p2", numericUpDown1.Value);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtAlisFiyatAs.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtSatisFiyatAs.Text));
            komut.Parameters.AddWithValue("@p5", comboBox1.SelectedValue);
            komut.Parameters.AddWithValue("@p6", txtUrunIdAs.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün başarıyla güncellendi.");
            veriGetir();
        }

        //Altta görmüş olduğunuz kod blokları menustrip aracında ismi yazan forma tıklandığında o formun karşınıza
        //gelmesini sağlar.
        private void ürünlerAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           frmUrun frmUrun = new frmUrun();
            frmUrun.ShowDialog();
        }

        private void istatistiklerAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmIstatistik frmIstatistik = new frmIstatistik();
            frmIstatistik.ShowDialog();
        }

        private void kategorilerAsToolStripMenuItes_Click(object sender, EventArgs e)
        {
            frmKategoriler frmKategoriler = new frmKategoriler();
            frmKategoriler.ShowDialog();
        }

        private void girişYapAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin frmAdmin = new frmAdmin();
            frmAdmin.ShowDialog();
        }

        private void kayıtEkleAsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmKayitEkle frmKayitEkle = new frmKayitEkle();
            frmKayitEkle.ShowDialog();
        }

       
    }
}

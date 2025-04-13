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
            komut.Parameters.AddWithValue("@p1", txtKullaniciAdiAs.Text);
            komut.Parameters.AddWithValue("@p2", txtSifreAs.Text);
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

        //Keydown event'i kullanıcı kolaylığını sağlamak içindir.
        //Buradaki amaç kullanıcı textbox'lara veri girişi yaptıktan sonra enter'a bastığı gibi diğer textbox'a veya
        //buton'a kolaylıkla geçiş yapmasıdır.
        private void txtKullaniciAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtSifreAs.Focus();
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGirisYap_Click(this, EventArgs.Empty);
        }
    }
}

namespace UrunTakip
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdiAs = new System.Windows.Forms.TextBox();
            this.txtSifreAs = new System.Windows.Forms.TextBox();
            this.btnGirisYapAs = new System.Windows.Forms.Button();
            this.lnklblKayitEkleAs = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(103, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(168, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre:";
            // 
            // txtKullaniciAdiAs
            // 
            this.txtKullaniciAdiAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdiAs.Location = new System.Drawing.Point(231, 72);
            this.txtKullaniciAdiAs.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAdiAs.Name = "txtKullaniciAdiAs";
            this.txtKullaniciAdiAs.Size = new System.Drawing.Size(173, 28);
            this.txtKullaniciAdiAs.TabIndex = 1;
            this.txtKullaniciAdiAs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKullaniciAdi_KeyDown);
            // 
            // txtSifreAs
            // 
            this.txtSifreAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifreAs.Location = new System.Drawing.Point(231, 119);
            this.txtSifreAs.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifreAs.Name = "txtSifreAs";
            this.txtSifreAs.PasswordChar = '●';
            this.txtSifreAs.Size = new System.Drawing.Size(173, 28);
            this.txtSifreAs.TabIndex = 2;
            this.txtSifreAs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifre_KeyDown);
            // 
            // btnGirisYapAs
            // 
            this.btnGirisYapAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYapAs.Location = new System.Drawing.Point(301, 168);
            this.btnGirisYapAs.Margin = new System.Windows.Forms.Padding(4);
            this.btnGirisYapAs.Name = "btnGirisYapAs";
            this.btnGirisYapAs.Size = new System.Drawing.Size(103, 32);
            this.btnGirisYapAs.TabIndex = 4;
            this.btnGirisYapAs.Text = "Giriş Yap";
            this.btnGirisYapAs.UseVisualStyleBackColor = true;
            this.btnGirisYapAs.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // lnklblKayitEkleAs
            // 
            this.lnklblKayitEkleAs.AutoSize = true;
            this.lnklblKayitEkleAs.Location = new System.Drawing.Point(194, 173);
            this.lnklblKayitEkleAs.Name = "lnklblKayitEkleAs";
            this.lnklblKayitEkleAs.Size = new System.Drawing.Size(100, 22);
            this.lnklblKayitEkleAs.TabIndex = 3;
            this.lnklblKayitEkleAs.TabStop = true;
            this.lnklblKayitEkleAs.Text = "Kayıt Ekle";
            this.lnklblKayitEkleAs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblKayitEkle_LinkClicked);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 265);
            this.Controls.Add(this.lnklblKayitEkleAs);
            this.Controls.Add(this.btnGirisYapAs);
            this.Controls.Add(this.txtSifreAs);
            this.Controls.Add(this.txtKullaniciAdiAs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAdiAs;
        private System.Windows.Forms.TextBox txtSifreAs;
        private System.Windows.Forms.Button btnGirisYapAs;
        private System.Windows.Forms.LinkLabel lnklblKayitEkleAs;
    }
}
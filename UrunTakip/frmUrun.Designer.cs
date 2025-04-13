namespace UrunTakip
{
    partial class frmUrun
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSatisFiyatAs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlisFiyatAs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunAdiAs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunIdAs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListeleAs = new System.Windows.Forms.Button();
            this.btnGüncelleAs = new System.Windows.Forms.Button();
            this.btnSilAs = new System.Windows.Forms.Button();
            this.btnKaydetAs = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünlerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistiklerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtEkleToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(881, 477);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSatisFiyatAs);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAlisFiyatAs);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUrunAdiAs);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUrunIdAs);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(911, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 240);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(99, 103);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(165, 22);
            this.numericUpDown1.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Kategori:";
            // 
            // txtSatisFiyatAs
            // 
            this.txtSatisFiyatAs.Location = new System.Drawing.Point(98, 174);
            this.txtSatisFiyatAs.Name = "txtSatisFiyatAs";
            this.txtSatisFiyatAs.Size = new System.Drawing.Size(166, 22);
            this.txtSatisFiyatAs.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Satış Fiyatı:";
            // 
            // txtAlisFiyatAs
            // 
            this.txtAlisFiyatAs.Location = new System.Drawing.Point(98, 142);
            this.txtAlisFiyatAs.Name = "txtAlisFiyatAs";
            this.txtAlisFiyatAs.Size = new System.Drawing.Size(166, 22);
            this.txtAlisFiyatAs.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alış Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stok";
            // 
            // txtUrunAdiAs
            // 
            this.txtUrunAdiAs.Location = new System.Drawing.Point(98, 69);
            this.txtUrunAdiAs.Name = "txtUrunAdiAs";
            this.txtUrunAdiAs.Size = new System.Drawing.Size(166, 22);
            this.txtUrunAdiAs.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı:";
            // 
            // txtUrunIdAs
            // 
            this.txtUrunIdAs.Location = new System.Drawing.Point(98, 38);
            this.txtUrunIdAs.Name = "txtUrunIdAs";
            this.txtUrunIdAs.Size = new System.Drawing.Size(166, 22);
            this.txtUrunIdAs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün ID:";
            // 
            // btnListeleAs
            // 
            this.btnListeleAs.Location = new System.Drawing.Point(1052, 329);
            this.btnListeleAs.Name = "btnListeleAs";
            this.btnListeleAs.Size = new System.Drawing.Size(123, 23);
            this.btnListeleAs.TabIndex = 3;
            this.btnListeleAs.Text = "Listele";
            this.btnListeleAs.UseVisualStyleBackColor = true;
            this.btnListeleAs.Click += new System.EventHandler(this.btnListeleAs_Click);
            // 
            // btnGüncelleAs
            // 
            this.btnGüncelleAs.Location = new System.Drawing.Point(1052, 387);
            this.btnGüncelleAs.Name = "btnGüncelleAs";
            this.btnGüncelleAs.Size = new System.Drawing.Size(123, 23);
            this.btnGüncelleAs.TabIndex = 9;
            this.btnGüncelleAs.Text = "Güncelle";
            this.btnGüncelleAs.UseVisualStyleBackColor = true;
            this.btnGüncelleAs.Click += new System.EventHandler(this.btnGüncelleAs_Click);
            // 
            // btnSilAs
            // 
            this.btnSilAs.Location = new System.Drawing.Point(1052, 416);
            this.btnSilAs.Name = "btnSilAs";
            this.btnSilAs.Size = new System.Drawing.Size(123, 23);
            this.btnSilAs.TabIndex = 8;
            this.btnSilAs.Text = "Sil";
            this.btnSilAs.UseVisualStyleBackColor = true;
            this.btnSilAs.Click += new System.EventHandler(this.btnSilAs_Click);
            // 
            // btnKaydetAs
            // 
            this.btnKaydetAs.Location = new System.Drawing.Point(1052, 358);
            this.btnKaydetAs.Name = "btnKaydetAs";
            this.btnKaydetAs.Size = new System.Drawing.Size(123, 23);
            this.btnKaydetAs.TabIndex = 7;
            this.btnKaydetAs.Text = "Kaydet";
            this.btnKaydetAs.UseVisualStyleBackColor = true;
            this.btnKaydetAs.Click += new System.EventHandler(this.btnKaydetAs_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünlerToolStripMenuItem1,
            this.istatistiklerToolStripMenuItem1,
            this.kategorilerToolStripMenuItem,
            this.girişYapToolStripMenuItem,
            this.kayıtEkleToolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1224, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünlerToolStripMenuItem1
            // 
            this.ürünlerToolStripMenuItem1.Name = "ürünlerToolStripMenuItem1";
            this.ürünlerToolStripMenuItem1.Size = new System.Drawing.Size(71, 24);
            this.ürünlerToolStripMenuItem1.Text = "Ürünler";
            this.ürünlerToolStripMenuItem1.Click += new System.EventHandler(this.ürünlerAsToolStripMenuItem1_Click);
            // 
            // istatistiklerToolStripMenuItem1
            // 
            this.istatistiklerToolStripMenuItem1.Name = "istatistiklerToolStripMenuItem1";
            this.istatistiklerToolStripMenuItem1.Size = new System.Drawing.Size(94, 24);
            this.istatistiklerToolStripMenuItem1.Text = "İstatistikler";
            this.istatistiklerToolStripMenuItem1.Click += new System.EventHandler(this.istatistiklerAsToolStripMenuItem1_Click);
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.kategorilerToolStripMenuItem.Text = "Kategoriler";
            this.kategorilerToolStripMenuItem.Click += new System.EventHandler(this.kategorilerAsToolStripMenuItes_Click);
            // 
            // girişYapToolStripMenuItem
            // 
            this.girişYapToolStripMenuItem.Name = "girişYapToolStripMenuItem";
            this.girişYapToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.girişYapToolStripMenuItem.Text = "Giriş Yap";
            this.girişYapToolStripMenuItem.Click += new System.EventHandler(this.girişYapAsToolStripMenuItem_Click);
            // 
            // kayıtEkleToolStripMenuItem3
            // 
            this.kayıtEkleToolStripMenuItem3.Name = "kayıtEkleToolStripMenuItem3";
            this.kayıtEkleToolStripMenuItem3.Size = new System.Drawing.Size(87, 24);
            this.kayıtEkleToolStripMenuItem3.Text = "Kayıt Ekle";
            this.kayıtEkleToolStripMenuItem3.Click += new System.EventHandler(this.kayıtEkleAsToolStripMenuItem3_Click);
            // 
            // frmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 629);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnGüncelleAs);
            this.Controls.Add(this.btnSilAs);
            this.Controls.Add(this.btnKaydetAs);
            this.Controls.Add(this.btnListeleAs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUrun";
            this.Load += new System.EventHandler(this.frmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUrunIdAs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListeleAs;
        private System.Windows.Forms.TextBox txtSatisFiyatAs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlisFiyatAs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunAdiAs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGüncelleAs;
        private System.Windows.Forms.Button btnSilAs;
        private System.Windows.Forms.Button btnKaydetAs;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem istatistiklerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kategorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtEkleToolStripMenuItem3;
    }
}
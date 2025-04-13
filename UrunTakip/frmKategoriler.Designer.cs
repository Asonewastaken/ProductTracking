namespace UrunTakip
{
    partial class frmKategoriler
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
            this.txtIDAs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKategoriAdAs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListeleAs = new System.Windows.Forms.Button();
            this.btnKaydetAs = new System.Windows.Forms.Button();
            this.btnSilAs = new System.Windows.Forms.Button();
            this.btnGüncelleAs = new System.Windows.Forms.Button();
            this.btnAraAs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(531, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIDAs);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKategoriAdAs);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtIDAs
            // 
            this.txtIDAs.Location = new System.Drawing.Point(304, 32);
            this.txtIDAs.Name = "txtIDAs";
            this.txtIDAs.Size = new System.Drawing.Size(93, 22);
            this.txtIDAs.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // txtKategoriAdAs
            // 
            this.txtKategoriAdAs.Location = new System.Drawing.Point(107, 32);
            this.txtKategoriAdAs.Name = "txtKategoriAdAs";
            this.txtKategoriAdAs.Size = new System.Drawing.Size(93, 22);
            this.txtKategoriAdAs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı:";
            // 
            // btnListeleAs
            // 
            this.btnListeleAs.Location = new System.Drawing.Point(589, 176);
            this.btnListeleAs.Name = "btnListeleAs";
            this.btnListeleAs.Size = new System.Drawing.Size(75, 23);
            this.btnListeleAs.TabIndex = 2;
            this.btnListeleAs.Text = "Listele";
            this.btnListeleAs.UseVisualStyleBackColor = true;
            this.btnListeleAs.Click += new System.EventHandler(this.btnListeleAs_Click);
            // 
            // btnKaydetAs
            // 
            this.btnKaydetAs.Location = new System.Drawing.Point(589, 205);
            this.btnKaydetAs.Name = "btnKaydetAs";
            this.btnKaydetAs.Size = new System.Drawing.Size(75, 23);
            this.btnKaydetAs.TabIndex = 3;
            this.btnKaydetAs.Text = "Kaydet";
            this.btnKaydetAs.UseVisualStyleBackColor = true;
            this.btnKaydetAs.Click += new System.EventHandler(this.btnKaydetAs_Click);
            // 
            // btnSilAs
            // 
            this.btnSilAs.Location = new System.Drawing.Point(589, 292);
            this.btnSilAs.Name = "btnSilAs";
            this.btnSilAs.Size = new System.Drawing.Size(75, 23);
            this.btnSilAs.TabIndex = 4;
            this.btnSilAs.Text = "Sil";
            this.btnSilAs.UseVisualStyleBackColor = true;
            this.btnSilAs.Click += new System.EventHandler(this.btnSilAs_Click);
            // 
            // btnGüncelleAs
            // 
            this.btnGüncelleAs.Location = new System.Drawing.Point(589, 234);
            this.btnGüncelleAs.Name = "btnGüncelleAs";
            this.btnGüncelleAs.Size = new System.Drawing.Size(75, 23);
            this.btnGüncelleAs.TabIndex = 5;
            this.btnGüncelleAs.Text = "Güncelle";
            this.btnGüncelleAs.UseVisualStyleBackColor = true;
            this.btnGüncelleAs.Click += new System.EventHandler(this.btnGüncelleAs_Click);
            // 
            // btnAraAs
            // 
            this.btnAraAs.Location = new System.Drawing.Point(589, 263);
            this.btnAraAs.Name = "btnAraAs";
            this.btnAraAs.Size = new System.Drawing.Size(75, 23);
            this.btnAraAs.TabIndex = 6;
            this.btnAraAs.Text = "Ara";
            this.btnAraAs.UseVisualStyleBackColor = true;
            this.btnAraAs.Click += new System.EventHandler(this.btnAraAs_Click);
            // 
            // frmKategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAraAs);
            this.Controls.Add(this.btnGüncelleAs);
            this.Controls.Add(this.btnSilAs);
            this.Controls.Add(this.btnKaydetAs);
            this.Controls.Add(this.btnListeleAs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmKategoriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategoriler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKategoriAdAs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListeleAs;
        private System.Windows.Forms.Button btnKaydetAs;
        private System.Windows.Forms.Button btnSilAs;
        private System.Windows.Forms.Button btnGüncelleAs;
        private System.Windows.Forms.Button btnAraAs;
        private System.Windows.Forms.TextBox txtIDAs;
        private System.Windows.Forms.Label label2;
    }
}


namespace Dolap
{
    partial class hesap
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pbUrunResmi = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAciklamasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunResmiDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.urunKategorisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dolapDataSet = new Dolap.DolapDataSet();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.urunlerTableAdapter = new Dolap.DolapDataSetTableAdapters.UrunlerTableAdapter();
            this.anasyfa = new System.Windows.Forms.LinkLabel();
            this.yenile = new System.Windows.Forms.Button();
            this.btng = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnHesapSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolapDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Açıklaması:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ürün Fiyatı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kategori:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Resim:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(178, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 22);
            this.textBox2.TabIndex = 4;
            // 
            // pbUrunResmi
            // 
            this.pbUrunResmi.Location = new System.Drawing.Point(178, 251);
            this.pbUrunResmi.Name = "pbUrunResmi";
            this.pbUrunResmi.Size = new System.Drawing.Size(206, 22);
            this.pbUrunResmi.TabIndex = 6;
            this.pbUrunResmi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(178, 195);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(206, 22);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(178, 83);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(206, 22);
            this.textBox5.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ürün Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 22);
            this.button2.TabIndex = 7;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(557, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunIDDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.urunAciklamasiDataGridViewTextBoxColumn,
            this.urunFiyatiDataGridViewTextBoxColumn,
            this.urunResmiDataGridViewImageColumn,
            this.urunKategorisiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 124);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // urunIDDataGridViewTextBoxColumn
            // 
            this.urunIDDataGridViewTextBoxColumn.DataPropertyName = "UrunID";
            this.urunIDDataGridViewTextBoxColumn.HeaderText = "UrunID";
            this.urunIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunIDDataGridViewTextBoxColumn.Name = "urunIDDataGridViewTextBoxColumn";
            this.urunIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            this.urunAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunAciklamasiDataGridViewTextBoxColumn
            // 
            this.urunAciklamasiDataGridViewTextBoxColumn.DataPropertyName = "UrunAciklamasi";
            this.urunAciklamasiDataGridViewTextBoxColumn.HeaderText = "UrunAciklamasi";
            this.urunAciklamasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunAciklamasiDataGridViewTextBoxColumn.Name = "urunAciklamasiDataGridViewTextBoxColumn";
            this.urunAciklamasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunFiyatiDataGridViewTextBoxColumn
            // 
            this.urunFiyatiDataGridViewTextBoxColumn.DataPropertyName = "UrunFiyati";
            this.urunFiyatiDataGridViewTextBoxColumn.HeaderText = "UrunFiyati";
            this.urunFiyatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunFiyatiDataGridViewTextBoxColumn.Name = "urunFiyatiDataGridViewTextBoxColumn";
            this.urunFiyatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunResmiDataGridViewImageColumn
            // 
            this.urunResmiDataGridViewImageColumn.DataPropertyName = "UrunResmi";
            this.urunResmiDataGridViewImageColumn.HeaderText = "UrunResmi";
            this.urunResmiDataGridViewImageColumn.MinimumWidth = 6;
            this.urunResmiDataGridViewImageColumn.Name = "urunResmiDataGridViewImageColumn";
            this.urunResmiDataGridViewImageColumn.Width = 125;
            // 
            // urunKategorisiDataGridViewTextBoxColumn
            // 
            this.urunKategorisiDataGridViewTextBoxColumn.DataPropertyName = "UrunKategorisi";
            this.urunKategorisiDataGridViewTextBoxColumn.HeaderText = "UrunKategorisi";
            this.urunKategorisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunKategorisiDataGridViewTextBoxColumn.Name = "urunKategorisiDataGridViewTextBoxColumn";
            this.urunKategorisiDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "Urunler";
            this.urunlerBindingSource.DataSource = this.dolapDataSet;
            // 
            // dolapDataSet
            // 
            this.dolapDataSet.DataSetName = "DolapDataSet";
            this.dolapDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // anasyfa
            // 
            this.anasyfa.AutoSize = true;
            this.anasyfa.Location = new System.Drawing.Point(719, 9);
            this.anasyfa.Name = "anasyfa";
            this.anasyfa.Size = new System.Drawing.Size(69, 16);
            this.anasyfa.TabIndex = 10;
            this.anasyfa.TabStop = true;
            this.anasyfa.Text = "Ana Sayfa";
            this.anasyfa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.anasyfa_LinkClicked);
            // 
            // yenile
            // 
            this.yenile.Location = new System.Drawing.Point(592, 297);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(75, 23);
            this.yenile.TabIndex = 11;
            this.yenile.Text = "Yenile";
            this.yenile.UseVisualStyleBackColor = true;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // btng
            // 
            this.btng.Location = new System.Drawing.Point(303, 294);
            this.btng.Name = "btng";
            this.btng.Size = new System.Drawing.Size(92, 23);
            this.btng.TabIndex = 12;
            this.btng.Text = "Güncelle";
            this.btng.UseVisualStyleBackColor = true;
            this.btng.Click += new System.EventHandler(this.btnGuncelle_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(401, 297);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnHesapSil
            // 
            this.btnHesapSil.Location = new System.Drawing.Point(673, 297);
            this.btnHesapSil.Name = "btnHesapSil";
            this.btnHesapSil.Size = new System.Drawing.Size(115, 23);
            this.btnHesapSil.TabIndex = 14;
            this.btnHesapSil.Text = "Hesabımı Sil";
            this.btnHesapSil.UseVisualStyleBackColor = true;
            this.btnHesapSil.Click += new System.EventHandler(this.btnHesapSil_Click);
            // 
            // hesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHesapSil);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btng);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.anasyfa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.pbUrunResmi);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "hesap";
            this.Text = "hesap";
            this.Load += new System.EventHandler(this.hesap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolapDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox pbUrunResmi;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DolapDataSet dolapDataSet;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private DolapDataSetTableAdapters.UrunlerTableAdapter urunlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAciklamasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunFiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn urunResmiDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKategorisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel anasyfa;
        private System.Windows.Forms.Button yenile;
        private System.Windows.Forms.Button btng;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnHesapSil;
    }
}
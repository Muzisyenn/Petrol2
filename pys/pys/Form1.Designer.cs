namespace pys
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnFisyazdir = new System.Windows.Forms.Button();
            this.textAracPlakasi = new System.Windows.Forms.TextBox();
            this.textAladigiyakitmiktari = new System.Windows.Forms.TextBox();
            this.textIslemiyapankisi = new System.Windows.Forms.TextBox();
            this.textödeyecegiücret = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboOdemeturu = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracPlakasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakitMiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemeTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemYapanCalisanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odenenUcretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakitFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasaTablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pysDataSet = new pys.pysDataSet();
            this.kasaTablosuTableAdapter = new pys.pysDataSetTableAdapters.KasaTablosuTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.lblYakitFiyati = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaTablosuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pysDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFisyazdir
            // 
            this.btnFisyazdir.Location = new System.Drawing.Point(345, 362);
            this.btnFisyazdir.Name = "btnFisyazdir";
            this.btnFisyazdir.Size = new System.Drawing.Size(75, 23);
            this.btnFisyazdir.TabIndex = 0;
            this.btnFisyazdir.Text = "Fiş Yazdır";
            this.btnFisyazdir.UseVisualStyleBackColor = true;
            this.btnFisyazdir.Click += new System.EventHandler(this.btnFisyazdir_Click);
            // 
            // textAracPlakasi
            // 
            this.textAracPlakasi.Location = new System.Drawing.Point(366, 67);
            this.textAracPlakasi.Name = "textAracPlakasi";
            this.textAracPlakasi.Size = new System.Drawing.Size(121, 22);
            this.textAracPlakasi.TabIndex = 1;
            // 
            // textAladigiyakitmiktari
            // 
            this.textAladigiyakitmiktari.Location = new System.Drawing.Point(366, 123);
            this.textAladigiyakitmiktari.Name = "textAladigiyakitmiktari";
            this.textAladigiyakitmiktari.Size = new System.Drawing.Size(121, 22);
            this.textAladigiyakitmiktari.TabIndex = 2;
            this.textAladigiyakitmiktari.TextChanged += new System.EventHandler(this.textAladigiyakitmiktari_TextChanged);
            // 
            // textIslemiyapankisi
            // 
            this.textIslemiyapankisi.Location = new System.Drawing.Point(366, 234);
            this.textIslemiyapankisi.Name = "textIslemiyapankisi";
            this.textIslemiyapankisi.Size = new System.Drawing.Size(121, 22);
            this.textIslemiyapankisi.TabIndex = 3;
            // 
            // textödeyecegiücret
            // 
            this.textödeyecegiücret.Location = new System.Drawing.Point(366, 178);
            this.textödeyecegiücret.Name = "textödeyecegiücret";
            this.textödeyecegiücret.Size = new System.Drawing.Size(121, 22);
            this.textödeyecegiücret.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Araç Plakası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aladığı Yakıt Miktarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ödeyeceği Ücret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "İşlemi Yapan Kişi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ödeme Türü";
            // 
            // comboOdemeturu
            // 
            this.comboOdemeturu.FormattingEnabled = true;
            this.comboOdemeturu.Items.AddRange(new object[] {
            "Kart",
            "Nakit"});
            this.comboOdemeturu.Location = new System.Drawing.Point(366, 281);
            this.comboOdemeturu.Name = "comboOdemeturu";
            this.comboOdemeturu.Size = new System.Drawing.Size(121, 24);
            this.comboOdemeturu.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.aracPlakasiDataGridViewTextBoxColumn,
            this.yakitMiktariDataGridViewTextBoxColumn,
            this.odemeTuruDataGridViewTextBoxColumn,
            this.ıslemYapanCalisanDataGridViewTextBoxColumn,
            this.odenenUcretDataGridViewTextBoxColumn,
            this.yakitFiyatiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kasaTablosuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(493, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(914, 291);
            this.dataGridView1.TabIndex = 11;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 125;
            // 
            // aracPlakasiDataGridViewTextBoxColumn
            // 
            this.aracPlakasiDataGridViewTextBoxColumn.DataPropertyName = "AracPlakasi";
            this.aracPlakasiDataGridViewTextBoxColumn.HeaderText = "AracPlakasi";
            this.aracPlakasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aracPlakasiDataGridViewTextBoxColumn.Name = "aracPlakasiDataGridViewTextBoxColumn";
            this.aracPlakasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // yakitMiktariDataGridViewTextBoxColumn
            // 
            this.yakitMiktariDataGridViewTextBoxColumn.DataPropertyName = "YakitMiktari";
            this.yakitMiktariDataGridViewTextBoxColumn.HeaderText = "YakitMiktari";
            this.yakitMiktariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yakitMiktariDataGridViewTextBoxColumn.Name = "yakitMiktariDataGridViewTextBoxColumn";
            this.yakitMiktariDataGridViewTextBoxColumn.Width = 125;
            // 
            // odemeTuruDataGridViewTextBoxColumn
            // 
            this.odemeTuruDataGridViewTextBoxColumn.DataPropertyName = "OdemeTuru";
            this.odemeTuruDataGridViewTextBoxColumn.HeaderText = "OdemeTuru";
            this.odemeTuruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odemeTuruDataGridViewTextBoxColumn.Name = "odemeTuruDataGridViewTextBoxColumn";
            this.odemeTuruDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıslemYapanCalisanDataGridViewTextBoxColumn
            // 
            this.ıslemYapanCalisanDataGridViewTextBoxColumn.DataPropertyName = "IslemYapanCalisan";
            this.ıslemYapanCalisanDataGridViewTextBoxColumn.HeaderText = "IslemYapanCalisan";
            this.ıslemYapanCalisanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıslemYapanCalisanDataGridViewTextBoxColumn.Name = "ıslemYapanCalisanDataGridViewTextBoxColumn";
            this.ıslemYapanCalisanDataGridViewTextBoxColumn.Width = 125;
            // 
            // odenenUcretDataGridViewTextBoxColumn
            // 
            this.odenenUcretDataGridViewTextBoxColumn.DataPropertyName = "OdenenUcret";
            this.odenenUcretDataGridViewTextBoxColumn.HeaderText = "OdenenUcret";
            this.odenenUcretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odenenUcretDataGridViewTextBoxColumn.Name = "odenenUcretDataGridViewTextBoxColumn";
            this.odenenUcretDataGridViewTextBoxColumn.Width = 125;
            // 
            // yakitFiyatiDataGridViewTextBoxColumn
            // 
            this.yakitFiyatiDataGridViewTextBoxColumn.DataPropertyName = "YakitFiyati";
            this.yakitFiyatiDataGridViewTextBoxColumn.HeaderText = "YakitFiyati";
            this.yakitFiyatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yakitFiyatiDataGridViewTextBoxColumn.Name = "yakitFiyatiDataGridViewTextBoxColumn";
            this.yakitFiyatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kasaTablosuBindingSource
            // 
            this.kasaTablosuBindingSource.DataMember = "KasaTablosu";
            this.kasaTablosuBindingSource.DataSource = this.pysDataSet;
            // 
            // pysDataSet
            // 
            this.pysDataSet.DataSetName = "pysDataSet";
            this.pysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kasaTablosuTableAdapter
            // 
            this.kasaTablosuTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Yakıt Litre Fiyatı";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblYakitFiyati
            // 
            this.lblYakitFiyati.Location = new System.Drawing.Point(118, 32);
            this.lblYakitFiyati.Name = "lblYakitFiyati";
            this.lblYakitFiyati.Size = new System.Drawing.Size(133, 22);
            this.lblYakitFiyati.TabIndex = 13;
            this.lblYakitFiyati.TextChanged += new System.EventHandler(this.textYakitLitreFiyati_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 587);
            this.Controls.Add(this.lblYakitFiyati);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboOdemeturu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textödeyecegiücret);
            this.Controls.Add(this.textIslemiyapankisi);
            this.Controls.Add(this.textAladigiyakitmiktari);
            this.Controls.Add(this.textAracPlakasi);
            this.Controls.Add(this.btnFisyazdir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaTablosuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pysDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFisyazdir;
        private System.Windows.Forms.TextBox textAracPlakasi;
        private System.Windows.Forms.TextBox textAladigiyakitmiktari;
        private System.Windows.Forms.TextBox textIslemiyapankisi;
        private System.Windows.Forms.TextBox textödeyecegiücret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboOdemeturu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private pysDataSet pysDataSet;
        private System.Windows.Forms.BindingSource kasaTablosuBindingSource;
        private pysDataSetTableAdapters.KasaTablosuTableAdapter kasaTablosuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracPlakasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakitMiktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemYapanCalisanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odenenUcretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakitFiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lblYakitFiyati;
    }
}


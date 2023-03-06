
namespace OtelYeni.UI
{
    partial class FrmFaturalandırma
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
            this.cmbMusteriAdi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.flpHizmetler = new System.Windows.Forms.FlowLayoutPanel();
            this.numHizmetAdeti = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.lblFiyat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHizmetAdeti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı:";
            // 
            // cmbMusteriAdi
            // 
            this.cmbMusteriAdi.FormattingEnabled = true;
            this.cmbMusteriAdi.Location = new System.Drawing.Point(129, 53);
            this.cmbMusteriAdi.Name = "cmbMusteriAdi";
            this.cmbMusteriAdi.Size = new System.Drawing.Size(226, 21);
            this.cmbMusteriAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Çıkış Tarihi:";
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.Location = new System.Drawing.Point(129, 102);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(226, 20);
            this.dtpCikisTarihi.TabIndex = 2;
            this.dtpCikisTarihi.ValueChanged += new System.EventHandler(this.dtpCikisTarihi_ValueChanged);
            // 
            // flpHizmetler
            // 
            this.flpHizmetler.Location = new System.Drawing.Point(12, 209);
            this.flpHizmetler.Name = "flpHizmetler";
            this.flpHizmetler.Size = new System.Drawing.Size(266, 218);
            this.flpHizmetler.TabIndex = 3;
            // 
            // numHizmetAdeti
            // 
            this.numHizmetAdeti.Location = new System.Drawing.Point(54, 447);
            this.numHizmetAdeti.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHizmetAdeti.Name = "numHizmetAdeti";
            this.numHizmetAdeti.Size = new System.Drawing.Size(120, 20);
            this.numHizmetAdeti.TabIndex = 0;
            this.numHizmetAdeti.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(181, 444);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(69, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Toplam Fiyat:";
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Location = new System.Drawing.Point(299, 379);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(129, 48);
            this.btnOdemeYap.TabIndex = 4;
            this.btnOdemeYap.Text = "ÖDEME YAP";
            this.btnOdemeYap.UseVisualStyleBackColor = true;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(415, 363);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(13, 13);
            this.lblFiyat.TabIndex = 5;
            this.lblFiyat.Text = "0";
            // 
            // FrmFaturalandırma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 491);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOdemeYap);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.numHizmetAdeti);
            this.Controls.Add(this.flpHizmetler);
            this.Controls.Add(this.dtpCikisTarihi);
            this.Controls.Add(this.cmbMusteriAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmFaturalandırma";
            this.Text = "Faturalandırma";
            this.Load += new System.EventHandler(this.FrmFaturalandırma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHizmetAdeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMusteriAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
        private System.Windows.Forms.FlowLayoutPanel flpHizmetler;
        private System.Windows.Forms.NumericUpDown numHizmetAdeti;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.Label lblFiyat;
    }
}

namespace OtelYeni.UI
{
    partial class FrmRapor
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAranacakKelime = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.dtpBirinciTrh = new System.Windows.Forms.DateTimePicker();
            this.dtpİkinciTrh = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTarihFitrele = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 137);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(578, 313);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Müşteri Adı";
            this.columnHeader1.Width = 175;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giriş Tarihi";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Çıkış Tarihi";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Oda";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fiyat";
            this.columnHeader5.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aranacak Müşteri Adi:";
            // 
            // txtAranacakKelime
            // 
            this.txtAranacakKelime.Location = new System.Drawing.Point(122, 14);
            this.txtAranacakKelime.Name = "txtAranacakKelime";
            this.txtAranacakKelime.Size = new System.Drawing.Size(178, 20);
            this.txtAranacakKelime.TabIndex = 2;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(225, 40);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // dtpBirinciTrh
            // 
            this.dtpBirinciTrh.Location = new System.Drawing.Point(366, 39);
            this.dtpBirinciTrh.Name = "dtpBirinciTrh";
            this.dtpBirinciTrh.Size = new System.Drawing.Size(200, 20);
            this.dtpBirinciTrh.TabIndex = 4;
            // 
            // dtpİkinciTrh
            // 
            this.dtpİkinciTrh.Location = new System.Drawing.Point(366, 75);
            this.dtpİkinciTrh.Name = "dtpİkinciTrh";
            this.dtpİkinciTrh.Size = new System.Drawing.Size(200, 20);
            this.dtpİkinciTrh.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tarih Aralığı Seçiniz";
            // 
            // btnTarihFitrele
            // 
            this.btnTarihFitrele.Location = new System.Drawing.Point(366, 108);
            this.btnTarihFitrele.Name = "btnTarihFitrele";
            this.btnTarihFitrele.Size = new System.Drawing.Size(200, 23);
            this.btnTarihFitrele.TabIndex = 3;
            this.btnTarihFitrele.Text = "Tarihe Göre Filtrele";
            this.btnTarihFitrele.UseVisualStyleBackColor = true;
            this.btnTarihFitrele.Click += new System.EventHandler(this.btnTarihFitrele_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.Location = new System.Drawing.Point(8, 108);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(86, 23);
            this.btnSifirla.TabIndex = 7;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // FrmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpİkinciTrh);
            this.Controls.Add(this.dtpBirinciTrh);
            this.Controls.Add(this.btnTarihFitrele);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAranacakKelime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "FrmRapor";
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.FrmRapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAranacakKelime;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DateTimePicker dtpBirinciTrh;
        private System.Windows.Forms.DateTimePicker dtpİkinciTrh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTarihFitrele;
        private System.Windows.Forms.Button btnSifirla;
    }
}

namespace OtelYeni.UI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ıslmelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturalandirmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tumRaporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcGonderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ıslmelerToolStripMenuItem,
            this.raporToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1073, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ıslmelerToolStripMenuItem
            // 
            this.ıslmelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acToolStripMenuItem,
            this.faturalandirmaToolStripMenuItem});
            this.ıslmelerToolStripMenuItem.Name = "ıslmelerToolStripMenuItem";
            this.ıslmelerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ıslmelerToolStripMenuItem.Text = "İslemler";
            this.ıslmelerToolStripMenuItem.Click += new System.EventHandler(this.ıslmelerToolStripMenuItem_Click);
            // 
            // acToolStripMenuItem
            // 
            this.acToolStripMenuItem.Name = "acToolStripMenuItem";
            this.acToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acToolStripMenuItem.Text = "Rezervasyon";
            this.acToolStripMenuItem.Click += new System.EventHandler(this.acToolStripMenuItem_Click);
            // 
            // faturalandirmaToolStripMenuItem
            // 
            this.faturalandirmaToolStripMenuItem.Name = "faturalandirmaToolStripMenuItem";
            this.faturalandirmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.faturalandirmaToolStripMenuItem.Text = "Faturalandırma";
            this.faturalandirmaToolStripMenuItem.Click += new System.EventHandler(this.faturalandirmaToolStripMenuItem_Click);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tumRaporlarToolStripMenuItem,
            this.tcGonderToolStripMenuItem});
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.raporToolStripMenuItem.Text = "Rapor";
            // 
            // tumRaporlarToolStripMenuItem
            // 
            this.tumRaporlarToolStripMenuItem.Name = "tumRaporlarToolStripMenuItem";
            this.tumRaporlarToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.tumRaporlarToolStripMenuItem.Text = "Tüm Raporlar";
            this.tumRaporlarToolStripMenuItem.Click += new System.EventHandler(this.tumRaporlarToolStripMenuItem_Click);
            // 
            // tcGonderToolStripMenuItem
            // 
            this.tcGonderToolStripMenuItem.Name = "tcGonderToolStripMenuItem";
            this.tcGonderToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.tcGonderToolStripMenuItem.Text = "Kimlik Numaraları Raporu";
            this.tcGonderToolStripMenuItem.Click += new System.EventHandler(this.tcGonderToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1073, 677);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Otel Yönetim Panali";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ıslmelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tumRaporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturalandirmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tcGonderToolStripMenuItem;
    }
}
using OtelYeni.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelYeni.UI
{
    public partial class FrmMain : Form
    {
        
        List<OdaRezervasyon> musteriler = new List<OdaRezervasyon>();
        List<Kullanım> kullanımlar = new List<Kullanım>();



        FrmMusteriOlustur ff1;
        FrmFaturalandırma ffat;
        FrmRapor frapor;
        FrmTcRapor frmTc;
        
        public FrmMain()
        {
            InitializeComponent();
        }

        private void vizyonMisyonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

                ff1 = new FrmMusteriOlustur();
                ff1.MdiParent = this;
                ff1.Show();
          
            
        }

        private void tumRaporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullanımlar = ffat.Tag as List<Kullanım>;
            frapor = new FrmRapor(kullanımlar);
            frapor.MdiParent= this;
            frapor.Show();
            ff1.WindowState = FormWindowState.Minimized;
            ffat.WindowState = FormWindowState.Minimized;
        }

        private void ıslmelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            

        }

        private void faturalandirmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteriler = ff1.Tag as List<OdaRezervasyon>;
            ffat = new FrmFaturalandırma(musteriler);
            ffat.MdiParent = this;
            ffat.Show();
            ff1.WindowState = FormWindowState.Minimized;
        }

        private void tcGonderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteriler = ff1.Tag as List<OdaRezervasyon>;
            frmTc = new FrmTcRapor(musteriler);
            frmTc.MdiParent = this;
            frmTc.Show();
            ff1.WindowState = FormWindowState.Minimized;
            ffat.WindowState = FormWindowState.Minimized;
            frapor.WindowState = FormWindowState.Minimized;

        }
    }
}

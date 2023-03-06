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
    public partial class FrmTcRapor : Form
    {
        private List<OdaRezervasyon> musteriler;

        public FrmTcRapor()
        {
            InitializeComponent();
        }

        public FrmTcRapor(List<OdaRezervasyon> musteriler) : this()
        {
            this.musteriler = musteriler;
        }

        private void FrmTcRapor_Load(object sender, EventArgs e)
        {
            ListViewGuncelle();
        }



        /// <summary>
        /// ListView e sadece raporun açıldığı gün giriş yapmış müşterilerin TC lerini listeleyen fonksiyon
        /// </summary>
        private void ListViewGuncelle()
        {
            listView1.Items.Clear();

            foreach (OdaRezervasyon item in musteriler)
            {

                if (item.GirisTarihi.Day == DateTime.Today.Day)
                {
                    ListViewItem h1 = new ListViewItem(item.Musteri.AdSoyad, 0);
                    h1.SubItems.Add(item.Musteri.TC);
                    listView1.Items.AddRange(new ListViewItem[] { h1 });
                }
            }
        }



        /// <summary>
        /// Gönder Eventi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGönder_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Kimlik Numaraları Bilgileri İlgili Kuruma Gönderilsin mi?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show("Kimlik Bilgileri Başarılı Bir Şekilde Gönderildi  ");
                listView1.Items.Clear();
            }
        }
    }
}

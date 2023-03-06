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
    public partial class FrmRapor : Form
    {
        private List<Kullanım> kullanımlar;


        public FrmRapor()
        {
            InitializeComponent();
        }


        public FrmRapor(List<Kullanım> kullanımlar):this()
        {
            this.kullanımlar = kullanımlar;
        }



        private void FrmRapor_Load(object sender, EventArgs e)
        {
            btnSifirla_Click(sender,e);

        }



        /// <summary>
        ///Arama butonu eventi. Textboxtaki kelimeyi kullanımlardaki müşteri isimleri ile karşılaştırır. Eğer içeren bir isim varsa listviewe sadece onun bilgilerini getirir. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranilanKelime = txtAranacakKelime.Text;

            listView1.Items.Clear();

            foreach (Kullanım item in kullanımlar)
            {

                if (ExtentionMetods.SayiVarMi(aranilanKelime) && item.Rezervasyon.Musteri.AdSoyad.ToLower().Contains(aranilanKelime.ToLower()))
                {
                    TabloyuDoldurma(item);
                }
                
            }
        }

        /// <summary>
        /// Tarihe göre seçilen aralıktaki otelde kalmış kişileri getirir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTarihFitrele_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();

            foreach (Kullanım item in kullanımlar)
            {

                if (dtpBirinciTrh.Value<=item.Rezervasyon.GirisTarihi && dtpİkinciTrh.Value>=item.CikisTarihi)
                {
                    TabloyuDoldurma(item);
                }
            }
        }

        /// <summary>
        /// Tüm müşteriler listesini getiri.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSifirla_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (Kullanım item in kullanımlar)
            {
                TabloyuDoldurma(item);

            }
        }

        /// <summary>
        /// Tabloyu dolduran fonksiyon
        /// </summary>
        /// <param name="item"></param>
        public void TabloyuDoldurma(Kullanım item)
        {
            ListViewItem h1 = new ListViewItem(item.Rezervasyon.Musteri.AdSoyad, 0);
            h1.SubItems.Add(item.Rezervasyon.GirisTarihi.ToString());
            h1.SubItems.Add(item.CikisTarihi.ToString());
            h1.SubItems.Add(item.Rezervasyon.Oda.Numarasi.ToString());
            h1.SubItems.Add(item.OdenenTutar.ToString());

            listView1.Items.AddRange(new ListViewItem[] { h1 });



        }
    }
}

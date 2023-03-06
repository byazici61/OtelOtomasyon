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
    public partial class FrmFaturalandırma : Form
    {
        private List<OdaRezervasyon> musteriler;
        double araToplam = 0;
        public FrmFaturalandırma()
        {
            InitializeComponent();
        }

        public FrmFaturalandırma(List<OdaRezervasyon> musteriler) : this()
        {
            this.musteriler = musteriler;
        }



        /// <summary>
        /// Load da combobox' aktif müşterilerin eklenmesi ve buzdolabını doldurması sağlandı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFaturalandırma_Load(object sender, EventArgs e)
        {
            cmbMusteriAdi.Items.AddRange(musteriler.ToArray());
            HizmetleriDoldur();
            
        }



        /// <summary>
        /// Hizmetleri Dolduran Fonksiyon
        /// </summary>
        private void HizmetleriDoldur()
        {
            flpHizmetler.Controls.Add(new CheckBox() { Text = "Kola", Tag = new Hizmet() { UrunAdi = "Kola", UrunFiyati = 20 } });
            flpHizmetler.Controls.Add(new CheckBox() { Text = "Maden Suyu", Tag = new Hizmet() { UrunAdi = "Maden Suyu", UrunFiyati = 10 } });
            flpHizmetler.Controls.Add(new CheckBox() { Text = "Su", Tag = new Hizmet() { UrunAdi = "Su", UrunFiyati = 5 } });
            flpHizmetler.Controls.Add(new CheckBox() { Text = "Bira", Tag = new Hizmet() { UrunAdi = "Bira", UrunFiyati = 50 } });
            flpHizmetler.Controls.Add(new CheckBox() { Text = "Şarap", Tag = new Hizmet() { UrunAdi = "Şarap", UrunFiyati = 150 } });
            flpHizmetler.Controls.Add(new CheckBox() { Text = "Enerji İçeceği", Tag = new Hizmet() { UrunAdi = "Enerji İçeceği", UrunFiyati = 75 } });
            flpHizmetler.Controls.Add(new CheckBox() { Text = "Ütü", Tag = new Hizmet() { UrunAdi = "Ütü", UrunFiyati = 50 } });
            flpHizmetler.Controls.Add(new CheckBox() { Text = "Masaj", Tag = new Hizmet() { UrunAdi = "Masaj", UrunFiyati = 250 } });
            flpHizmetler.Controls.Add(new CheckBox() { Text = "Sauna", Tag = new Hizmet() { UrunAdi = "Sauna", UrunFiyati = 350 } });


        }
        


        /// <summary>
        /// Müşterinin otelde kaç gün kaldığını hesaplayan fonksiyon
        /// </summary>
        /// <param name="GirisTarihi"></param>
        /// <param name="CikisTarihi"></param>
        /// <returns></returns>
        public int KalinacakGunSayisi(DateTime GirisTarihi, DateTime CikisTarihi)
        {
            return (CikisTarihi - GirisTarihi).Days;

        }



        /// <summary>
        /// dtp değeri değiştiğinde çalışan event. dtp değişince Fiyat label'ını güncelleyen fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            
            foreach (var item in musteriler)
            {
                if (cmbMusteriAdi.SelectedItem == item)
                {
                    araToplam = item.Oda.Fiyat * KalinacakGunSayisi(item.GirisTarihi, dtpCikisTarihi.Value);
                    lblFiyat.Text = (araToplam).ToString();
                    break;
                }
            }
        }


        /// <summary>
        /// Ekle butonunun eventi. Hizmetlerdeki işaretli hizmetin fiyatına ve numericupdown değerine göre fiyat labelini günceller.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEkle_Click(object sender, EventArgs e)
        {
            foreach (CheckBox item in flpHizmetler.Controls)
            {
                if (item.Checked)
                {
                    araToplam += Convert.ToDouble(numHizmetAdeti.Value) * Convert.ToDouble(item.Tag.ToString());
                    lblFiyat.Text = araToplam.ToString();
                }

            }

        }



        List<Kullanım> Kullanımlar = new List<Kullanım>();



        /// <summary>
        /// Ödeme yapma butonunun eventi. Bir messageBox açar yanıta göre seçili müşteri bilgilerini kullanarak kullanımlar sınıfından bir nesne oluşturur. Ve formu resetler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Toplam Hizmet Bedeli : " + araToplam + " TL\nÖdeme Yapmak İstermisiniz ? ", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            #region Uzun ekleme işlemi(if-foreach-if)

            //if (dg == DialogResult.Yes)
            //{
            //    foreach (var item in musteriler)
            //    {
            //        if (cmbMusteriAdi.Text== item.Musteri.AdSoyad)
            //        {
            //            Kullanımlar.Add(new Kullanım()
            //            {
            //                Rezervasyon = new OdaRezervasyon()
            //                {
            //                    GirisTarihi = item.GirisTarihi,
            //                    Musteri = item.Musteri,
            //                    Oda = item.Oda,
            //                },
            //                CikisTarihi = dtpCikisTarihi.Value,
            //                OdenenTutar = araToplam,

            //            });
            //        }

            //    }


            //    MessageBox.Show(araToplam + "TL tutarındaki ödeminiz Alınmıştır. Bizi tercih ettiğiniz için teşekkürler.");
            //    flpHizmetler.Refresh();
            //    cmbMusteriAdi.SelectedItem = null;
            //    numericUpDown1.Value = 0;
            //    araToplam = 0;
            //    lblFiyat.Text = araToplam.ToString();
            //    dtpCikisTarihi.Value = DateTime.Now;
            //    HizmetleriTemizle();
            //    this.Tag = Kullanımlar;///diğer formlarda kullanmak için kullanımlar listesini bu formun tagına ekledik.
            //}
            #endregion
            foreach (var item in musteriler)
            {
                if (dg == DialogResult.Yes &&cmbMusteriAdi.Text==item.Musteri.AdSoyad)
                {
                    Kullanımlar.Add(new Kullanım()
                    {
                        Rezervasyon = new OdaRezervasyon()
                        {
                            GirisTarihi = item.GirisTarihi,
                            Musteri = item.Musteri,
                            Oda = item.Oda,
                        },
                        CikisTarihi = dtpCikisTarihi.Value,
                        OdenenTutar = araToplam,

                    });
                    MessageBox.Show(araToplam + "TL tutarındaki ödeminiz Alınmıştır. Bizi tercih ettiğiniz için teşekkürler.");


                    cmbMusteriAdi.Items.RemoveAt(cmbMusteriAdi.SelectedIndex);
                   
                    SayfayiYenile();
                    this.Tag = Kullanımlar;///diğer formlarda kullanmak için kullanımlar listesini bu formun tagına ekledik.
                    

                }

                        
            }
           
        }



        /// <summary>
        /// sayfayı ilk andaki haline geri getirir.
        /// </summary>
        private void SayfayiYenile()
        {
            foreach (CheckBox item in flpHizmetler.Controls)
            {
                if (item.Checked)
                {
                    item.Checked = false;
                }

            }
            araToplam = 0;
            lblFiyat.Text = araToplam.ToString();
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {

                    item.Controls.Clear();
                    item.Text = "";
                }
                if (item is DateTimePicker || item is NumericUpDown)
                {
                    item.ResetText();
                    
                }


            }

        }


       
    }
}

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
    public partial class FrmMusteriOlustur : Form
    {
        public FrmMusteriOlustur()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Form 1 Load olduğu zaman odalarları panale düzgünce dizmesi için gerekli işlemler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            OdalariOlustur();
            
        }


        Button tiklanilanButton;
        OdaRezervasyon SecilenOda;

        /// <summary>
        /// FrmMusteriOlusuturda odaları istenilen düzene göre dizer
        /// </summary>
        public void OdalariOlustur()
        {
            Button btnKral = new Button();
            btnKral.Text = "Kral Dairesi";
            btnKral.BackColor = Color.DarkOrange;
            //Butonlara tıkladığımızda oda bilgilerine ulaşabilmek adına Tag ataması yapıldı.
            btnKral.Tag = new OdaRezervasyon()
            {
                Oda = new Oda()
                {
                    Fiyat = 500,
                    Numarasi = 131,
                    OdaDurumu = OdaDurumu.Bos,
                    YatakSayisi = 7

                }
            };
            btnKral.Width = 400;
            btnKral.Height = 50;
            btnKral.Click += Btn_Click;// Bütün butonlarda kullanılmak üzere aynı işleve sahip event

            flKat4.Controls.Add(btnKral);
            for (int i = 100; i < 131; i++)
            {
                if (i < 110)
                {
                    Button btn1 = new Button();
                    btn1.Text = (i).ToString();
                    btn1.BackColor = Color.DarkOrange;
                    btn1.Tag = new OdaRezervasyon()
                    {
                        Oda = new Oda()
                        {
                            Fiyat = 50,
                            Numarasi = int.Parse(btn1.Text),
                            OdaDurumu = OdaDurumu.Bos,
                            YatakSayisi = 1

                        }


                    };
                    btn1.Click += Btn_Click;

                    flKat1.Controls.Add(btn1);

                }
                if (i < 120 && i > 109)
                {
                    Button btn1 = new Button();
                    btn1.Text = (i).ToString();
                    btn1.BackColor = Color.DarkOrange;
                    btn1.Tag = new OdaRezervasyon()
                    {
                        Oda = new Oda()
                        {
                            Fiyat = 50,
                            Numarasi = int.Parse(btn1.Text),
                            OdaDurumu = OdaDurumu.Bos,
                            YatakSayisi = 1

                        }


                    };
                    btn1.Click += Btn_Click;

                    flKat2.Controls.Add(btn1);

                }
                if (i < 130 && i > 119)
                {
                    Button btn1 = new Button();
                    btn1.Text = (i).ToString();
                    btn1.BackColor = Color.DarkOrange;
                    btn1.Tag = new OdaRezervasyon()
                    {
                        Oda = new Oda()
                        {
                            Fiyat = 50,
                            Numarasi = int.Parse(btn1.Text),
                            OdaDurumu = OdaDurumu.Bos,
                            YatakSayisi = 1

                        }


                    };
                    btn1.Click += Btn_Click;

                    flKat3.Controls.Add(btn1);

                }

            }



        }



        /// <summary>
        /// Herhangi bir butona(oda) tıklandığında müşteri bilgileri panelini aktif eden, ilgili labele oda bilgilerini yazdıran event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Click(object sender, EventArgs e)
        {
            tiklanilanButton = sender as Button;
            gbMusteriBilgileri.Enabled = true;

            SecilenOda = tiklanilanButton.Tag as OdaRezervasyon;

            lblOdaBilgileri.Text = SecilenOda.Oda.ToString();
        }



        List<OdaRezervasyon> musteriler = new List<OdaRezervasyon>();

        /// <summary>
        /// İlgili formdaki kontrolleri tek fonksiyonda kontorl edip ona göre bool değer dönen fonksiyon
        /// </summary>
        /// <param name="Rezervasyonlar"></param>
        /// <returns></returns>
        public bool Kontroller(OdaRezervasyon Rezervasyonlar)
        {

            return Rezervasyonlar.Oda.OdaDurumu == OdaDurumu.Bos
           && Rezervasyonlar.Oda.YatakSayisi >= numKisiSayisi.Value
           && numKisiSayisi.Value > 0
           && numYas.Value >= 18
           && txtAdSoyad.Text.IsimKontrolEt()
           && mtxTc.Text.TcKontrol()
           && ExtentionMetods.SayiVarMi(txtAdSoyad.Text)
           && ExtentionMetods.BosMu(txtAdSoyad.Text, mtbTlfn.Text, mtxTc.Text);

        }




        /// <summary>
        /// Ekle butonuna tıklandığında oda biligleri ve girilen müşteri biligilerini kullanılarak OdaREzervasyon tipinde bir nesne oluşturması sağlando
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEkle_Click(object sender, EventArgs e)
        {

            OdaRezervasyon Rezervasyonlar = tiklanilanButton.Tag as OdaRezervasyon;

            //oda dolu ise ekleme yapılmamalı
            if (Kontroller(Rezervasyonlar))
            {
                //rez al
                Rezervasyonlar.Musteri = new Musteri()
                {
                    AdSoyad = txtAdSoyad.Text,
                    Yas = Convert.ToDouble(numYas.Value),
                    TC = mtxTc.Text,
                    Tel = mtbTlfn.Text
                };
                Rezervasyonlar.Oda.OdaDurumu = OdaDurumu.Dolu;
                Rezervasyonlar.GirisTarihi = dtpGirisTarihi.Value;
                tiklanilanButton.BackColor = Color.Red;

                musteriler.Add(Rezervasyonlar);

                MessageBox.Show("Müşteri eklendi");


                FormuEskiHalineGetir(gbMusteriBilgileri);

                gbMusteriBilgileri.Enabled = false;


                this.Tag = musteriler;//Diğer formlara müşteriler listesini gönderebilmek için bu formun tag Bilgisine  ilgili  liste atıldı.
            }
            else
            {
                if (!(txtAdSoyad.Text.IsimKontrolEt())
                     && mtxTc.Text.TcKontrol()
                     && ExtentionMetods.SayiVarMi(txtAdSoyad.Text)
                     && ExtentionMetods.BosMu(txtAdSoyad.Text, mtbTlfn.Text, mtxTc.Text))
                {
                    MessageBox.Show("Tüm alanları eksiksiz ve doğru bir şekilde doldurunuz");

                }
                else
                {
                    MessageBox.Show(numYas.Value >= 18 && Rezervasyonlar.Oda.OdaDurumu == OdaDurumu.Bos
                    ? "Odanın Kontenjanı Rezervasyon İçim Yeterli değil"
                    : Rezervasyonlar.Oda.OdaDurumu == OdaDurumu.Bos
                        ? "18 yaşından Küçük Biri İçin Rezervasyon Oluşturulamaz"
                        : "Lütfen Boş Bir Oda seçiniz"
                    );

                }

            }

            lblOdaBilgileri.Text = "";


        }



        /// <summary>
        /// Formdaki textbox ve masked textboxları gezerek onları boş hale getiren fonksiyon
        /// </summary>
        private void FormuEskiHalineGetir(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox || item is MaskedTextBox)
                {
                    item.Text = "";
                }
                if (item is DateTimePicker)
                {
                    item.ResetText();
                }

            }
        }


        /// <summary>
        /// Oda temizleme labelına tıklandığında odayı temizleniyor olarak işaretleyen fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblOdaTemizle_Click(object sender, EventArgs e)
        {
            SecilenOda = tiklanilanButton.Tag as OdaRezervasyon;
            SecilenOda.Oda.OdaDurumu = OdaDurumu.Temizlik;
            tiklanilanButton.BackColor = Color.Cyan;
            lblOdaBilgileri.Text = SecilenOda.Oda.ToString();

        }
    }
}

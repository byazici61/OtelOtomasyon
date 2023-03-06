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
            int sayac = 99;

            //Kral dairesi
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

                },
                Musteri = new Musteri()
                {

                }

            };
            btnKral.Width = 400;
            btnKral.Height = 50;
            btnKral.Click += Btn_Click;// Bütün butonlarda kullanılmak üzere aynı işleve sahip event

            flKat4.Controls.Add(btnKral);

            //1. Kat 
            for (int i = 0; i < 10; i++)
            {
                Button btn1 = new Button();
                btn1.Text = (++sayac).ToString();
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
            //2.Kat
            for (int i = 0; i < 10; i++)
            {
                Button btn1 = new Button();
                btn1.Text = (++sayac).ToString();
                btn1.BackColor = Color.DarkOrange;
                btn1.Tag = new OdaRezervasyon()
                {
                    Oda = new Oda()
                    {
                        Fiyat = 100,
                        Numarasi = int.Parse(btn1.Text),
                        OdaDurumu = OdaDurumu.Bos,
                        YatakSayisi = 2,
                    }


                };
                btn1.Click += Btn_Click;

                flKat2.Controls.Add(btn1);
            }


            //3.Kat
            for (int i = 0; i < 10; i++)
            {
                Button btn1 = new Button();
                btn1.Text = (++sayac).ToString();
                btn1.BackColor = Color.DarkOrange;
                btn1.Tag = new OdaRezervasyon()
                {
                    Oda = new Oda()
                    {
                        Fiyat = 150,
                        Numarasi = int.Parse(btn1.Text),
                        OdaDurumu = OdaDurumu.Bos,
                        YatakSayisi = 3
                    }

                };
                btn1.Click += Btn_Click;

                flKat3.Controls.Add(btn1);
            }

        }


        Button tiklanilanButton;
        OdaRezervasyon SecilenOda;





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

        private void label9_Click(object sender, EventArgs e)
        {
            //tiklanilanButton = sender as Button;
            SecilenOda = tiklanilanButton.Tag as OdaRezervasyon;
            SecilenOda.Oda.OdaDurumu = OdaDurumu.Temizlik;
            tiklanilanButton.BackColor = Color.Cyan;
            lblOdaBilgileri.Text = SecilenOda.Oda.ToString();

        }
    }
}

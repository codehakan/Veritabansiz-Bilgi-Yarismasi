using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veritabansız_Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            butonlari_devre_disi_birak();
            buton_isim_default();
            richTextBox1.Enabled = false;
            zaman.Text = zamann.ToString();
        }
        int soru_sayisi = 0;
        int yanlis_sorusayisi = 0;
        int dogru_sorusayisi = 0;
        int zamann = 30;
        public void butonlari_devre_disi_birak()
        {
            cevap1.Enabled = false;
            cevap2.Enabled = false;
            cevap3.Enabled = false;
            cevap4.Enabled = false;
        }
        public void butonlari_aktiflestir()
        {
            cevap1.Enabled = true;
            cevap2.Enabled = true;
            cevap3.Enabled = true;
            cevap4.Enabled = true;
        }
        public void buton_renk_normal()
        {
            cevap1.BackColor = DefaultBackColor;
            cevap2.BackColor = DefaultBackColor;
            cevap3.BackColor = DefaultBackColor;
            cevap4.BackColor = DefaultBackColor;
        }
        public void buton_isim_default()
        {
            cevap1.Text = "-";
            cevap2.Text = "-";
            cevap3.Text = "-";
            cevap4.Text = "-";
        }
        private void basla_Click(object sender, EventArgs e)
        {
            butonlari_aktiflestir();
            basla.Text = "SONRAKİ";
            basla.Enabled = false;
            buton_renk_normal();
            soru_sayisi++;
            if(soru_sayisi==1)
            {
                richTextBox1.Text = "Türkiye'nin başkanti neresidir?";
                cevap1.Text = "Sivas";
                cevap2.Text = "Ankara";
                cevap3.Text = "İstanbul";
                cevap4.Text = "İzmir";
            }
            if (soru_sayisi == 2)
            {
                richTextBox1.Text = "HZ.Muhammed(s.a)'in babasının adı nedir?";
                cevap1.Text = "Abdurrahman";
                cevap2.Text = "Abdullah";
                cevap3.Text = "Ebu Talip";
                cevap4.Text = "Ebu Leheb";
            }
            if (soru_sayisi == 3) 
            {
                richTextBox1.Text = "ReloadMt2 Kaç Yılında Kurulmuştur?";
                cevap1.Text = "2011";
                cevap2.Text = "2012";
                cevap3.Text = "2013";
                cevap4.Text = "2014";
            }
            
            bilgilendirme.Visible = false;
            timer1.Start();
        }

        private void cevap1_Click(object sender, EventArgs e)
        {
            if(soru_sayisi==1)
            {
                butonlari_devre_disi_birak();
                cevap1.BackColor = Color.Yellow;
                cevap2.BackColor = Color.Green;
                bilgilendirme.Text = "Yanlış Cevap\nverdiniz.";
                bilgilendirme.Visible = true;
                yanlis_sorusayisi += 1;
                yanlis_sayisi.Text = yanlis_sorusayisi.ToString();
                basla.Enabled = true;
            }
            if(soru_sayisi==2)
            {
                butonlari_devre_disi_birak();
                cevap1.BackColor = Color.Yellow;
                cevap2.BackColor = Color.Green;
                bilgilendirme.Text = "Yanlış Cevap\nverdiniz.";
                bilgilendirme.Visible = true;
                yanlis_sorusayisi += 1;
                yanlis_sayisi.Text = yanlis_sorusayisi.ToString();
                basla.Enabled = true;
            }
            if(soru_sayisi==3)
            {
                butonlari_devre_disi_birak();
                cevap1.BackColor = Color.Yellow;
                cevap2.BackColor = Color.Green;
                bilgilendirme.Text = "Yanlış Cevap\nverdiniz.";
                bilgilendirme.Visible = true;
                yanlis_sorusayisi += 1;
                yanlis_sayisi.Text = yanlis_sorusayisi.ToString();
                basla.Enabled = true;
            }
        }

        private void cevap2_Click(object sender, EventArgs e)
        {
            if (soru_sayisi == 1)
            {
                butonlari_devre_disi_birak();
                cevap2.BackColor = Color.Green;
                bilgilendirme.Text = "Doğru Cevap\nverdiniz.";
                bilgilendirme.Visible = true;
                dogru_sorusayisi += 1;
                dogru_sayisi.Text = dogru_sorusayisi.ToString();
                basla.Enabled = true;
            }
            if (soru_sayisi == 2)
            {
                butonlari_devre_disi_birak();
                cevap2.BackColor = Color.Green;
                bilgilendirme.Text = "Doğru Cevap\nverdiniz.";
                bilgilendirme.Visible = true;
                dogru_sorusayisi += 1;
                dogru_sayisi.Text = dogru_sorusayisi.ToString();
                basla.Enabled = true;
            }
            if (soru_sayisi == 3)
            {
                butonlari_devre_disi_birak();
                cevap2.BackColor = Color.Yellow;
                cevap3.BackColor = Color.Green;
                bilgilendirme.Text = "Yanlış Cevap\nverdiniz.";
                bilgilendirme.Visible = true;
                yanlis_sorusayisi += 1;
                yanlis_sayisi.Text = yanlis_sorusayisi.ToString();
                basla.Enabled = true;
            }
        }

        private void cevap3_Click(object sender, EventArgs e)
        {
            if (soru_sayisi == 1)
            {
                butonlari_devre_disi_birak();
                cevap3.BackColor = Color.Yellow;
                cevap2.BackColor = Color.Green;
                bilgilendirme.Text = "Yanlış Cevap\nverdiniz.";
                bilgilendirme.Visible = true;
                yanlis_sorusayisi += 1;
                yanlis_sayisi.Text = yanlis_sorusayisi.ToString();
                basla.Enabled = true;
            }
            if (soru_sayisi == 2)
            {
                butonlari_devre_disi_birak();
                cevap3.BackColor = Color.Yellow;
                cevap2.BackColor = Color.Green;
                bilgilendirme.Text = "Yanlış Cevap\nverdiniz.";
                bilgilendirme.Visible = true;
                yanlis_sorusayisi += 1;
                yanlis_sayisi.Text = yanlis_sorusayisi.ToString();
                basla.Enabled = true;
            }
            if (soru_sayisi == 3)
            {
                butonlari_devre_disi_birak();
                cevap3.BackColor = Color.Green;
                bilgilendirme.Text = "Doğru Cevap\nverdiniz.";
                bilgilendirme.Visible = true;
                dogru_sorusayisi += 1;
                dogru_sayisi.Text = dogru_sorusayisi.ToString();
                basla.Enabled = true;
            }
        }

        private void cevap4_Click(object sender, EventArgs e)
        {
            if (soru_sayisi == 1)
            {
                butonlari_devre_disi_birak();
                cevap4.BackColor = Color.Yellow;
                cevap2.BackColor = Color.Green;
                bilgilendirme.Text = "Yanlış Cevap\nverdiniz.";
                bilgilendirme.Visible = true;
                yanlis_sorusayisi += 1;
                yanlis_sayisi.Text = yanlis_sorusayisi.ToString();
                basla.Enabled = true;
            }
            if (soru_sayisi == 2)
            {
                butonlari_devre_disi_birak();
                cevap4.BackColor = Color.Yellow;
                cevap2.BackColor = Color.Green;
                bilgilendirme.Text = "Yanlış Cevap\nverdiniz.";
                bilgilendirme.Visible = true;
                yanlis_sorusayisi += 1;
                yanlis_sayisi.Text = yanlis_sorusayisi.ToString();
                basla.Enabled = true;
            }
            if (soru_sayisi == 3)
            {
                butonlari_devre_disi_birak();
                cevap4.BackColor = Color.Yellow;
                cevap2.BackColor = Color.Green;
                bilgilendirme.Text = "Yanlış Cevap\nverdiniz.";
                bilgilendirme.Visible = true;
                yanlis_sorusayisi += 1;
                yanlis_sayisi.Text = yanlis_sorusayisi.ToString();
                basla.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zamann -= 1;
            zaman.Text = zamann.ToString();
            if(zamann==0)
            {
                buton_isim_default();
                buton_renk_normal();
                butonlari_devre_disi_birak();
                bilgilendirme.Text = "Süreniz Sona\nerdi..";
                bilgilendirme.Visible = true;
                richTextBox1.Text = "Süreniz sona erdiği için yarışmaya devam edemiyorsunuz." +
                    "Lütfen sürenizi daha dikkatli kullanmaya çalışınız.";
                timer1.Stop();
            }
            if (soru_sayisi >= 4)
            {
                soru_sayisi += 1;
                basla.Text = "BİTTİ";
                richTextBox1.Text = "Yarışmamız Sona Ermiştir. Katıldığınız için teşekkür ederiz." +
                    "Bir sonraki yarışmada görüşmek üzre..";
                butonlari_devre_disi_birak();
                buton_isim_default();
                timer1.Stop();
                bilgilendirme.Text = (30 - Convert.ToInt32(zaman.Text)).ToString()+" saniyede\ntamamladınız.";
                bilgilendirme.Visible = true;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace YönlendirilmisProje
{
    public partial class KayitSayfasi : Form
    {
        

        String kullaniciAdi;
        String sifre;
        String sifreTk;
        Boolean Admin;
        public KayitSayfasi()
        {
            InitializeComponent();

        }

        private void adminRadio_CheckedChanged(object sender, EventArgs e)
        {
            //Kullanıcıdan admin bilgisi alma 
            Admin = true;
        }

        private void kullaniciRadio_CheckedChanged(object sender, EventArgs e)
        {
            //Kullanıcıdan admin bilgisi alma 
            Admin = false;
        }


        private void KayıtOl_Click(object sender, EventArgs e)
        {

            //Formda girilen verileri çekme
            kullaniciAdi = kullaniciAd.Text;
            sifre = kullaniciSifre.Text;
            sifreTk = sifreTekrar.Text;
            //Kullanıcı adı şifre uygunluk ve eşleşme kontrolu
            if (kullaniciAdi.Length < 6 && kullaniciAdi !="")
            {
                System.Windows.Forms.MessageBox.Show("Kullanıcı adı 6 harften kısa olamaz veya boş bırakılamaz");
            }
            else if (sifre != sifreTk)
            {
                System.Windows.Forms.MessageBox.Show("Sifreler eşleşmiyor");
            }
            else
            {
                //SQL bağlantısı
                string yol = "Data Source=veri.s3db;Version=3;";
                SQLiteConnection baglanti = new SQLiteConnection(yol);
                baglanti.Open();
                string sql = "insert into kullanici(kullaniciAdi,sifre,kayitTarih,admin) values(@kullaniciAdi,@sifre,@kayitTarih,@admin)";
                SQLiteCommand komut = new SQLiteCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAd.Text);
                komut.Parameters.AddWithValue("@sifre", kullaniciSifre.Text);

                DateTime kayıtTarih = DateTime.Now;
                komut.Parameters.AddWithValue("@kayitTarih", kayıtTarih);

                komut.Parameters.AddWithValue("@admin", Admin);

                //SQL bağlantısı sonlandırma 
                komut.ExecuteNonQuery();
                baglanti.Dispose();
                komut.Dispose();


                MessageBox.Show("Kayıt işleminiz tamamlandı");
                //Giriş sayfasına yönlendirme 
                this.Hide();
                GirisSayfasi f1 = new GirisSayfasi();
                f1.ShowDialog();

            }

        }

     
    }
}

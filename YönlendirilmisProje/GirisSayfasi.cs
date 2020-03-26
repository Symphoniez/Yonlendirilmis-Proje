using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YönlendirilmisProje
{
    public partial class GirisSayfasi : Form
    {
        public GirisSayfasi()   
        {
            InitializeComponent();
        }

        private void KayitButton_Click(object sender, EventArgs e)
        {
            //Kayıt sayfasına yönlendirme 



            {
                this.Hide();
                KayitSayfasi f2 = new KayitSayfasi();

                f2.ShowDialog();

            }
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            //girilen kullanıcı adı ve şifre değerleri
           string kullaniciAdi = textBox1.Text.Trim();
           string sifre = textBox2.Text.Trim();
            //veri tabanı bağlantısı
            string yol = "Data Source=verit.s3db;";
            SQLiteConnection baglanti = new SQLiteConnection(yol);
           
            baglanti.Open();

            //veri tabanından veri çekişi
            string sql = "select * from kullanici where kullaniciAdi=@adi AND sifre=@sifresi";
            SQLiteParameter prm1 = new SQLiteParameter("adi", kullaniciAdi);
            SQLiteParameter prm2 = new SQLiteParameter("sifresi", sifre);
            SQLiteCommand komut = new SQLiteCommand(sql, baglanti);
            komut.Parameters.Add(prm1);
            komut.Parameters.Add(prm2);
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(komut);
            da.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                string row = String.Format("Id: {0} kullaniciAdi: {1} sifre : {2} kayitTarih: {3}  Admin: {4}", item[0], item[1], item[2], item[3], item[4]);
                
                if (item[1].Equals(kullaniciAdi) && item[2].Equals(sifre))
                {
                    

                        //kullanici adı doğruluk kontrolu
                        if (item[4] is true)
                        {
                            //admin anasayfa yönlendirme
                            this.Hide();
                            adminAnaSayfa f3 = new adminAnaSayfa();
                            f3.ShowDialog();
                            break;
                        }
                        else
                        {
                            this.Hide();
                            Anasayfacs f4 = new Anasayfacs();
                            f4.ShowDialog();
                            break;
                        }
                    
                  
                    }
                else
                {
                    MessageBox.Show("Kullanıcı adınız veya şifreniz yanlış");
                    break;
                }
            }

        }
    }
}

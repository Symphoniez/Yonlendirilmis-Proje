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
    public partial class Form1 : Form
    {
        String kullaniciAdi;
        String sifre;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            kullaniciAdi = textBox1.Text;
            sifre = textBox2.Text;
            //kullanici adi şifre kontrolu


            string yol = "Data Source=veri.s3db;";
            SQLiteConnection baglanti = new SQLiteConnection(yol);
            baglanti.Open();
            string sql = "select * from kullanici";
            SQLiteCommand komut = new SQLiteCommand(sql, baglanti);
            

            


        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Kayıt sayfasına yönlendirme 

           
                
                {
                    this.Hide();
                    Form2 f2 = new Form2();

                    f2.ShowDialog();
                    
            }
          
        }

     
    }
}

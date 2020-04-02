using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YönlendirilmisProje
{
    public partial class malz_ekle : Form
    {
        public malz_ekle()
        {
            InitializeComponent();
        }

        private void ekle_vazgec_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void e_ekle_Click(object sender, EventArgs e)
        {
            string  kategori= malz_Ekle_Kategori.Text;
            string adi = malz_Ekle_ismi.Text;
            string  adet= malz_Ekle_Adet.Text;
            DateTime eklenmeTarih = DateTime.Now;
            if (kategori !="" && kategori.Trim().Length > 3)
            {

          
            string yol = "Data Source=verit.s3db;Version=3;";
            SQLiteConnection baglanti = new SQLiteConnection(yol);
            baglanti.Open();
            string sql = "insert into malzemeler(kategori,malz_adi,Adet,tarih) values(@kategori,@malz_adi,@adet,@tarih)";
            SQLiteCommand komut = new SQLiteCommand(sql, baglanti);
           
            komut.Parameters.AddWithValue("@kategori", kategori);
            komut.Parameters.AddWithValue("@malz_adi", adi);
            komut.Parameters.AddWithValue("@adet", adet);
            komut.Parameters.AddWithValue("@tarih", eklenmeTarih);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ekleme işleminiz başarıyla tamamlandı");
            this.Hide();
            
            }


        }
    }

}

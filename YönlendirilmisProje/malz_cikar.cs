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
    public partial class malz_cikar : Form
    {
        public String kullanici;
        public malz_cikar()
        {
            InitializeComponent();


        }
        void doldur()
        {
            string yol = "Data Source=verit.s3db;";
            SQLiteConnection baglanti = new SQLiteConnection(yol);
            baglanti.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From malzemeler", baglanti);
            malzemeler2.Rows.Clear();
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    malzemeler2.Rows.Add(new object[] {
            read.GetValue(0),
            read.GetValue(1),
            read.GetValue(2),
            read.GetValue(3),
            read.GetValue(4),
            read.GetValue(5),
             
            });
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            doldur();
        }
        private void Sil_Click(object sender, EventArgs e)
        {
            string yol = "Data Source=verit.s3db;";
            SQLiteConnection baglanti = new SQLiteConnection(yol);
            baglanti.Open();
            foreach (DataGridViewRow item in malzemeler2.SelectedRows)
            {

                    int numara = Convert.ToInt32(item.Cells[0].Value);
                    SQLiteCommand cmd = new SQLiteCommand("Delete From malzemeler where malz_id ='"+numara+"'",baglanti);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                
            }
            doldur();
        }

        private void malz_cikar_Load(object sender, EventArgs e)
        {
            label1.Text = kullanici;
        }
    }
}

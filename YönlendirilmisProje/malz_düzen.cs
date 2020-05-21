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
    public partial class malz_düzen : Form
    {
        public String kullanici;

        public malz_düzen()
        {
            InitializeComponent();
        }
        SQLiteConnection baglanti = new SQLiteConnection("Data Source=verit.s3db");
         
        void doldur()
        {
           // string yol = "Data Source=verit.s3db;";
           
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
        private void malz_düzen_Load(object sender, EventArgs e)
        {
            doldur();
        }



        private void güncel_Click(object sender, EventArgs e)
        {
            doldur();
        }

        private void malzemeler2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void malzemeler2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}

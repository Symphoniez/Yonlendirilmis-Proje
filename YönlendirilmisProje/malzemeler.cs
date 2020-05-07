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
    public partial class malzemeler : Form
    {
        public malzemeler()
        { 
            InitializeComponent();
        } 
        
   

        private void malzemeler_Load(object sender, EventArgs e)
        {
        

           
   

            string yol = "Data Source=verit.s3db;";
            SQLiteConnection baglanti = new SQLiteConnection(yol);
            baglanti.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From malzemeler", baglanti);
            malzemeler1.Rows.Clear();
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
            malzemeler1.Rows.Add(new object[] {
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
    }

   

}


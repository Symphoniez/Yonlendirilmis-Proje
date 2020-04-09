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
        
/*            malz_list.Columns.Add("ID", 50);
            malz_list.Columns.Add("Kategori", 100);
            malz_list.Columns.Add("Adı", 100);
            malz_list.Columns.Add("Adet", 100);
            malz_list.Columns.Add("Açıklama", 400);
            */
            string id = "", kategori ="" ,adi ="" ,adet ="",aciklama="";
   

            string yol = "Data Source=verit.s3db;";
            SQLiteConnection baglanti = new SQLiteConnection(yol);
            string sql = "select * from malzemeler";
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand(sql, baglanti);
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(komut);
            da.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {

            }

        }
    }

   

}


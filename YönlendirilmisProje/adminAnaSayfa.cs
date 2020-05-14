using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YönlendirilmisProje
{
    public partial class adminAnaSayfa : Form
    {   
        public String kullaniciAdi;
        public adminAnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            malz_ekle ekle = new malz_ekle();

            ekle.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            this.Hide();
            malzemeler malz = new malzemeler();
            malz.kullanici = kullaniciAdi;
            malz.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {   
            this.Hide();
            malz_cikar cikarma = new malz_cikar();
            cikarma.kullanici = kullaniciAdi;
            cikarma.ShowDialog();
            
        }

        private void adminAnaSayfa_Load(object sender, EventArgs e)
        {
            label1.Text = kullaniciAdi;
        }
    }
}

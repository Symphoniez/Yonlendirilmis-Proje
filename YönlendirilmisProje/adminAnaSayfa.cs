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
        public adminAnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            malz_ekle ekle = new malz_ekle();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            malzemeler malz = new malzemeler();
            malz.ShowDialog();
            this.Hide();
        }
    }
}

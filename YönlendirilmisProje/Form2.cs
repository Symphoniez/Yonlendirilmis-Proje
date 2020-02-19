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
    public partial class Form2 : Form
    {
        String kullaniciAdi;
        String sifre;
        String sifreTk;
        String Admin;
        public Form2()
        {
            InitializeComponent();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Admin = "True";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Admin = "False";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            kullaniciAdi = textBox1.Text;
            sifre = textBox2.Text;
            sifreTk = textBox3.Text;

            if (kullaniciAdi.Length < 5)
            {
                System.Windows.Forms.MessageBox.Show("Kullanıcı adı 5 harften kısa olamaz");
            }else if(sifre != sifreTk){
                System.Windows.Forms.MessageBox.Show("Sifreler eşleşmiyor");
            }
            else
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }

           
        }
    }
}

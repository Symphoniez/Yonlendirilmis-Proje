﻿using System;
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
    public partial class Anasayfacs : Form
    {
        public string yazi;
        public Anasayfacs()
        {
            InitializeComponent();
        }
        GirisSayfasi giris = new GirisSayfasi();
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Anasayfacs_Load(object sender, EventArgs e)
        {
            label1.Text = yazi;
        }
    }
}

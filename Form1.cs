﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saat = 0, dakika = 0, saniye = 0;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label1.Text = saniye.ToString();
            if (saniye == 60)
            {
                dakika++;
                label2.Text = dakika.ToString();
                saniye = 0;

                if (dakika == 3)
                {
                    saat = saat + 1;
                    label3.Text = saat.ToString();
                    dakika = 0;
                }
            }
        }
    }
}

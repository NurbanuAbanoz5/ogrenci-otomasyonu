﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace öğrenc_otomasyonu
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void notGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 fr = new Form8();
            fr.Show();
        }
    }
}

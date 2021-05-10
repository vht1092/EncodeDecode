using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TUONGHD;

namespace EncodeDecode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text;
            txtString2.Text = EnCode.EnCodeToString(txtString1.Text, key);
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text;
            txtString2.Text = EnCode.DeCodeToString(txtString1.Text, key);
        }
    }
}
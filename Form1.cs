using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CLASS_BOL_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bol eleman = new bol();
        private void button1_Click(object sender, EventArgs e)
        {
            eleman.sayı = Convert.ToInt16(textBox1.Text);
            eleman.bölen = Convert.ToInt16(textBox2.Text);
            label3.Text = eleman.bul();


        }
    }
}

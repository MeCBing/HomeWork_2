using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luwei
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Class1.SetTotal(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text);
            label9.Text = label9.Text + Class1.Printf();
        }
    }
}

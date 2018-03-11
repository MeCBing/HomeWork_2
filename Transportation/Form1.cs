using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transportation.Models;

namespace Transportation
{
    public partial class Form1 : Form
    {
        bool open = true;
        List<TransportatiionTable> listTest = new List<TransportatiionTable>();
        public Form1()
        {
            InitializeComponent();
            Class1.SetData();
            PrintfData();
        }
        public void PrintfData()
        {
            dataGridView1.DataSource = Class2.PrintfData();
            listTest = Class2.PrintfData();
        }
        private void SetCombox_1()
        {
            open = false;
            comboBox1.DataSource = null;
            comboBox1.DataSource = Class2.SetCombox_1();
            open = true;
        }
        private void SetCombox_2()
        {
            open = false;
            comboBox1.DataSource = null;
            comboBox1.DataSource = Class2.SetCombox_2();
            open = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SetCombox_1();
            comboBox2.DataSource = null;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SetCombox_2();
            comboBox2.DataSource = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (open)
            {
                List<string> list1 = new List<string>();
                if (radioButton1.Checked)
                {
                    var data = listTest.Where((x) => x.StartState == comboBox1.SelectedItem.ToString());
                    foreach (var d in data)
                    {
                        list1.Add(d.EndState);
                    }
                }
                else
                {
                    var data = listTest.Where((x) => x.EndState == comboBox1.SelectedItem.ToString());
                    foreach (var d in data)
                    {
                        list1.Add(d.StartState);
                    }
                }
                comboBox2.DataSource = list1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = Class2.CheckPrintf(radioButton1.Checked,checkBox1.Checked, checkBox2.Checked, comboBox1.SelectedItem.ToString(),comboBox2.SelectedItem.ToString());
        }
    }
}

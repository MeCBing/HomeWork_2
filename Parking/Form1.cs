using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            SetDateTime();
        }
        public void SetDateTime()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd tt hh:mm";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy/MM/dd tt hh:mm";
            dateTimePicker3.ShowUpDown = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money = 0;
            DateTime time = dateTimePicker1.Value;
            DateTime time1 = dateTimePicker3.Value;
            TimeSpan span = time1 - time;
            //MessageBox.Show($"{time.Hour}");
            if(span.Minutes<0)
            {
                MessageBox.Show("請勿亂輸入");
            }
            else
            {
                int day = span.Days;
                int hour = span.Hours;
                int minute = span.Minutes;
                hour = hour + (day * 24);
                if (time.Minute == time1.Minute)
                {
                    hour++;
                    minute = 0;
                }
                if (hour < 2)
                {
                    money = (hour * 2 * 30) + (minute / 30 * 30);
                }
                else if (hour < 4)
                {
                    money = ((hour - 2) * 2 * 40) + (minute / 30 * 40) + (2 * 2 * 30);
                }
                else
                {
                    money = ((hour - 4) * 2 * 60) + (minute / 30 * 60) + (2 * 2 * 30) + (2 * 2 * 40);
                }
                //MessageBox.Show($"{span}\n{money}");
                label7.Text = " 總金額 :  " + money.ToString("C");
            }
        }
    }
}

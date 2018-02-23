using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reminder
{
    public partial class Form1 : Form
    {
        public int s = 6;
        public int m = 0;
        public int h = 0;
        public bool timer = true;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = (h + " : " + m + " : " + s);
            timer1.Start();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = (h + " : " + m + " : " + s);
            if (timer == true)
            {
                CountDown();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CountDown()
        {
            s--;
            if (s < 0)
            {
                s = 59;
                m--;
            }
            if (m < 0)
            {
                m = 59;
                h--;
            }
            if (s == 0 && m == 0 && h == 0)
            {
                MessageBox.Show("Time's up");
                timer = false;
            }
        }
    }
}

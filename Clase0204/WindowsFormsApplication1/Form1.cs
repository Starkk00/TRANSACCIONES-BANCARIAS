using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Step = 4;

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i=0; i <= 24; i++)
            { 
                progressBar1.PerformStep();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 24; i++)
            {
                progressBar1.PerformStep();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button2.BackColor=Color.Red;
            timer2.Enabled = true;
            timer2.Interval = 3000;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            button3.BackColor = Color.Yellow;
            timer3.Enabled= true;
            timer3.Interval = 2000;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            button4.BackColor = Color.Green;
            timer4.Enabled = true;
            timer4.Interval = 5000;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

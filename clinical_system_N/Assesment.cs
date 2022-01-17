using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinical_system_N
{
    public partial class Assesment : Form
    {
        public Assesment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C90 = new OrthopedicUnit_Calender();
            C90.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Records C91 = new Records();
            C91.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Finance C92 = new Finance();
            C92.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C93 = new AdminSettings();
            C93.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Investigation C94 = new Investigation();
            C94.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            diagnosisdoc C95 = new diagnosisdoc();
            C95.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Services C96 = new Services();
            C96.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            X_Ray C97 = new X_Ray();
            C97.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            prescription C98 = new prescription();
            C98.Show();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

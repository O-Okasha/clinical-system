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
    public partial class Add_Patient : Form
    {
        public Add_Patient()
        {
            InitializeComponent();
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient_record C31 = new patient_record();
            C31.Show();
        }

        private void Calender_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C32 = new OrthopedicUnit_Calender();
            C32.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient_record C33 = new patient_record();
            C33.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Finance C34 = new Finance();
            C34.Show();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C35 = new AdminSettings();
            C35.Show();
        }
    }
}


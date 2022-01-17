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
    public partial class Finance : Form
    {

        public Finance()
        {

            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C44 = new OrthopedicUnit_Calender();
            C44.Show();
        }

        private void Finance_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient_record C45 = new patient_record();
            C45.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {


        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C46 = new AdminSettings();
            C46.Show();
        }
    }
}

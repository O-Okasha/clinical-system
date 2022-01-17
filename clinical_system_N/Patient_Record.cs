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
    public partial class patient_record : Form
    {

        public patient_record()

        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Patient C50 = new Add_Patient();
            C50.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void patient_record_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C51 = new OrthopedicUnit_Calender();
            C51.Show();

        }
        private void toolStripContainer2_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient_record C52 = new patient_record();
            C52.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Finance C53 = new Finance();
            C53.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C55 = new AdminSettings();
            C55.Show();

        }
    }
}
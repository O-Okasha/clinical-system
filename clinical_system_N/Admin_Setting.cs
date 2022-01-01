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
    public partial class AdminSettings : Form
    {
        
        public AdminSettings()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Doctor C37 = new Add_Doctor();
            C37.Show();
        }

        private void AdminSettings_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C39 = new OrthopedicUnit_Calender();
            C39.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Device C38 = new Add_Device();
            C38.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient_record C40 = new patient_record();
            C40.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Finance C41 = new Finance();
            C41.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C42 = new AdminSettings();
            C42.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C43 = new AdminSettings();
            C43.Show();
        }
    }
}

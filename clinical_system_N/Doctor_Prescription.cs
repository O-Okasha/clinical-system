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
    public partial class Doctor_Prescription : Form
    {
        public Doctor_Prescription()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Assesment C105 = new Assesment();
            C105.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void Doctor_Prescription_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C100 = new OrthopedicUnit_Calender();
            C100.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Records C101 = new Records();
            C101.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Finance C102 = new Finance();
            C102.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C103 = new AdminSettings();
            C103.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Investigation C104 = new Investigation();
            C104.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Physio C106 = new Physio();
            C106.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Services C107 = new Services();
            C107.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            X_Ray C108 = new X_Ray();
            C108.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C77 = new OrthopedicUnit_Calender();
            C77.Show();
        }
    }
}

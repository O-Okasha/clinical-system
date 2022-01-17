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
    public partial class diagnosisdoc : Form
    {
        public diagnosisdoc()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Investigation C81 = new Investigation();
            C81.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void OrthopedicUnit_Load(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Assesment C82 = new Assesment();
            C82.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Services C83 = new Services();
            C83.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            X_Ray C84 = new X_Ray();
            C84.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            prescription C85 = new prescription();
            C85.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            App C99 = new App();
            C99.Show();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C77 = new OrthopedicUnit_Calender();
            C77.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Records C78 = new Records();
            C78.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Finance C79 = new Finance();
            C79.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C80 = new AdminSettings();
            C80.Show();
        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click_1(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C85 = new OrthopedicUnit_Calender();
            C85.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Records C86 = new Records();
            C86.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Finance C87 = new Finance();
            C87.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C88 = new AdminSettings();
            C88.Show();
        }

        private void btn_AddPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAppointment C89 = new AddAppointment();
            C89.Show();
        }

        private void App_Load(object sender, EventArgs e)
        {

        }
    }
}

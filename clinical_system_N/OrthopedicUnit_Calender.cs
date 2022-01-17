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
    public partial class OrthopedicUnit_Calender : Form
    {
        public OrthopedicUnit_Calender()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Physiotherape_Calender C2 = new Physiotherape_Calender();
            C2.Show();
        }

        private void panel46_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient_record C3 = new patient_record();
            C3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Finance C4 = new Finance();
            C4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C5 = new AdminSettings();
            C5.Show();
        }

        private void btn_AddApp_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAppointment C6 = new AddAppointment();
            C6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit C11 = new OrthopedicUnit();
            C11.Show();
        }

        private void OrthopedicUnit_Calender_Load(object sender, EventArgs e)
        {

        }

        private void fl_AppContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

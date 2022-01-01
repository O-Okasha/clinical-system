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
    public partial class Add_Doctor : Form
    {
        public Add_Doctor()
        {
            InitializeComponent();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_doctor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C27 = new AdminSettings();
            C27.Show();

        }

        private void Calender_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C28 = new OrthopedicUnit_Calender();
            C28.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient_record C29 = new patient_record();
            C29.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Finance C30 = new Finance();
            C30.Show();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            
        }
    }
}

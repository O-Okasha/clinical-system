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
    public partial class AddAppointment : Form
    {
        
        public AddAppointment()
        {
            InitializeComponent();
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Physiotherape_Calender C22 = new Physiotherape_Calender();
            C22.Show();
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C21 = new OrthopedicUnit_Calender();
            C21.Show();
            
        }

        private void btn_AddPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Patient C16 = new Add_Patient();
            C16.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient_record C18 = new patient_record();
            C18.Show();

        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit C17 = new OrthopedicUnit();
            C17.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Finance C19 = new Finance();
            C19.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C20 = new AdminSettings();
            C20.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

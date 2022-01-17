using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace clinical_system_N
{
    public partial class AddAppointment : Form
    {

        public AddAppointment()
        {
            InitializeComponent();

        }

        private bool isValid_name(string inp)
        {
            Regex check = new Regex(@"^([A-Z][a-z-A-z]+)$");
            bool valid = check.IsMatch(inp);
            return valid;

        }

        private bool Validation()
        {
            //firstname validation
            if (Phone.Text == "" || maskedTextBox1.Text.Length > 50 || maskedTextBox1.Text.Contains(" ") || !isValid_name(maskedTextBox1.Text))
            {
                label_First_Name.ForeColor = Color.Red;
                label_First_Name.Text = "invalid input";
                return false;
            }
            else
            {
                label_First_Name.Text = "";
            }
            //patient ID Validation
            if (patientID.Text == "")
            {
                label_Patient_ID.ForeColor = Color.Red;
                label_Patient_ID.Text = "invalid input";
                return false;
            }
            else
            {
                label_Patient_ID.Text = "";
            }
            //Phone Number Validation
            Regex check = new Regex(@"^?([0,1]{2})?([0,1,2,5]{1})?([0-9]{8})$");
            bool valid = check.IsMatch(Phone.Text);
            if (Phone.Text == "" || valid == false)
            {
                label_Phone_Number.ForeColor = Color.Red;
                label_Phone_Number.Text = "invalid input";
                return false;
            }
            else
            {
                label_Phone_Number.Text = "";
            }
            //Last Name Validation
            if (last.Text == "" || last.Text.Length > 50 || last.Text.Contains(" ") || !isValid_name(last.Text))
            {
                label_Last_Name.ForeColor = Color.Red;
                label_Last_Name.Text = "invalid input";
                return false;
            }
            else
            {
                label_Last_Name.Text = "";
            }
            //Date Validation
            if (Date_time == false)
            {
                label_Date.ForeColor = Color.Red;
                label_Date.Text = "invalid input";
                return false;
            }
            else
            {
                label_Date.Text = "";
            }
            //clinic validation
            if (comboBox1.Text == "")
            {
                label_Clinic.ForeColor = Color.Red;
                label_Clinic.Text = "invalid input";
                return false;
            }
            else
            {
                label_Clinic.Text = "";
            }
            return true;
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
            bool validation = Validation();
            //if all inputs are true proceed to database
            if (validation)
            {
                this.Hide();
                OrthopedicUnit_Calender C21 = new OrthopedicUnit_Calender();
                C21.Show();
            }
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
            Records C18 = new Records();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool Date_time = false;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Date_time = true;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

using clinical_system_N.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinical_system_N
{
    public partial class Add_Patient : Form
    {
        public Add_Patient()
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
            //First Name Validation
            if (firstName.Text == "" || firstName.Text.Length > 50 || firstName.Text.Contains(" ") || !isValid_name(firstName.Text))
            {
                label_First_Name.ForeColor = Color.Red;
                label_First_Name.Text = "invalid input";
                return false;
            }
            else
            {
                label_First_Name.Text = "";
            }
            //Phone Number Validation
            Regex check = new Regex(@"^?([0,1]{2})?([0,1,2,5]{1})?([0-9]{8})$");
            bool valid = check.IsMatch(phoneNumber.Text);
            if (phoneNumber.Text == "" || valid == false)
            {
                label_Phone_Number.ForeColor = Color.Red;
                label_Phone_Number.Text = "invalid input";
                return false;
            }
            else
            {
                label_Phone_Number.Text = "";
            }
            //Email Validation
            check = new Regex(@"^?([A-Za-z0-9]{3,20})\@?([A-Za-z]{3,10}).?(com)$");
            valid = check.IsMatch(email.Text);
            if (email.Text == "" || valid == false)
            {
                label_Email.ForeColor = Color.Red;
                label_Email.Text = "invalid input";
                return false;
            }
            else
            {
                label_Email.Text = "";
            }
            //Address Validation
            if (address.Text == "" || address.Text.Length > 50 || !isValid_name(address.Text))
            {
                label_Address.ForeColor = Color.Red;
                label_Address.Text = "invalid input";
                return false;
            }
            else
            {
                label_Address.Text = "";
            }
            //Last Name Validation
            if (lastName.Text == "" || lastName.Text.Length > 50 || lastName.Text.Contains(" ") || !isValid_name(lastName.Text))
            {
                label_Last_Name.ForeColor = Color.Red;
                label_Last_Name.Text = "invalid input";
                return false;
            }
            else
            {
                label_Last_Name.Text = "";
            }
            //National ID Validation
            check = new Regex(@"^?([1-9]{1})?([0-9]{2})?(0[1-9]|1[0-2])?(0[1-9]|1[0-9]|2[0-9]|3[0-1])?([0-9]{2})?([0-9]{5})$$");
            valid = check.IsMatch(nationalID.Text);
            if (nationalID.Text == "" || valid == false)
            {
                label_National_ID.ForeColor = Color.Red;
                label_National_ID.Text = "invalid input";
                return false;
            }
            else
            {
                label_National_ID.Text = "";
            }
            //City Validation
            if (city.Text == "" || !isValid_name(city.Text))
            {
                label_City.ForeColor = Color.Red;
                label_City.Text = "invalid input";
                return false;
            }
            else
            {
                label_City.Text = "";
            }
            //Patient Employer Validation
            if (profession.Text == "" || !isValid_name(profession.Text))
            {
                label_Patient_Employer.ForeColor = Color.Red;
                label_Patient_Employer.Text = "invalid input";
                return false;
            }
            else
            {
                label_Patient_Employer.Text = "";
            }
            //Blood Type Validation
            check = new Regex(@"^?(A|B|AB|O)?([+,-])$");
            valid = check.IsMatch(profession.Text);
            if (profession.Text == "" || valid == false)
            {
                label_Blood_Type.ForeColor = Color.Red;
                label_Blood_Type.Text = "invalid input";
                return false;
            }
            else
            {
                label_Blood_Type.Text = "";
            }
            //Gender Validation
            if (!ckMale.Checked && !ckFemale.Checked)
            {
                label_Gender.ForeColor = Color.Red;
                label_Gender.Text = "invalid input";
                return false;
            }
            else if (ckMale.Checked && ckFemale.Checked)
            {
                label_Gender.ForeColor = Color.Red;
                label_Gender.Text = "invalid input";
                return false;
            }
            else
            {
                label_Gender.Text = "";
            }
            //Martrial Status Validation
            if (!ckMarried.Checked && !ckSingle.Checked && !ckDivorced.Checked)
            {
                label_Martrial_Status.ForeColor = Color.Red;
                label_Martrial_Status.Text = "invalid input";
                return false;
            }
            if (ckMarried.Checked && ckSingle.Checked && ckDivorced.Checked)
            {
                label_Martrial_Status.ForeColor = Color.Red;
                label_Martrial_Status.Text = "invalid input";
                return false;
            }
            else if (ckDivorced.Checked && ckSingle.Checked)
            {
                label_Martrial_Status.ForeColor = Color.Red;
                label_Martrial_Status.Text = "invalid input";
                return false;
            }
            else if (ckDivorced.Checked && ckMarried.Checked)
            {
                label_Martrial_Status.ForeColor = Color.Red;
                label_Martrial_Status.Text = "invalid input";
                return false;
            }
            else if (ckSingle.Checked && ckMarried.Checked)
            {
                label_Martrial_Status.ForeColor = Color.Red;
                label_Martrial_Status.Text = "invalid input";
                return false;
            }
            else
            {
                label_Martrial_Status.Text = "";
            }
            //Date of Birth Validation
            if (Date_time == false)
            {
                label_Date_Of_Birth.ForeColor = Color.Red;
                label_Date_Of_Birth.Text = "invalid input";
                return false;
            }
            else
            {
                label_Date_Of_Birth.Text = "";
            }
            return true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool validation = Validation();
            //if all inputs are true proceed to database
            if (validation)
            {
                try
                {
                    List<string> list = new List<string>();
                    DBController db = new DBController();
                    list.Add(firstName.Text);
                    list.Add(lastName.Text);
                    list.Add(dateTimePicker1.Text);
                    list.Add(nationalID.Text);
                    string gender = ckMale.Checked ? "M" : "F";
                    list.Add(gender);
                    list.Add(email.Text);
                    list.Add(phoneNumber.Text);
                    list.Add(address.Text);
                    string status = "";
                    if (ckDivorced.Checked) { status = "D"; }
                    else if (ckMarried.Checked) { status = "M"; }
                    else if (ckSingle.Checked) { status = "S"; }
                    list.Add(status);
                    list.Add(profession.Text);
                    list.Add(city.Text);

                    db.CUD(CrudType.insert, "EMPLOYEE", list);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Hide();
                patient_record C31 = new patient_record();
                C31.Show();
            }
        }

        private void Calender_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrthopedicUnit_Calender C32 = new OrthopedicUnit_Calender();
            C32.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Records C33 = new Records();
            C33.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Finance C34 = new Finance();
            C34.Show();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C35 = new AdminSettings();
            C35.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool Date_time = false;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Date_time = true;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}


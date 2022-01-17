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
using clinical_system_N.models;
using MySql.Data.MySqlClient;

namespace clinical_system_N
{
    public partial class AdminSettings : Form
    {

        public AdminSettings()
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
            //Full Name Validation
            if (firstName.Text == "" || firstName.Text.Length > 50 || !isValid_name(firstName.Text))
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
            //password Validation
            if (password.Text == "")
            {
                label_Password.ForeColor = Color.Red;
                label_Password.Text = "invalid input";
                return false;
            }
            else
            {
                label_Password.Text = "";
            }
            // confirm password validation
            if (textBox7.Text == "")
            {
                label_Confirm_password.ForeColor = Color.Red;
                label_Confirm_password.Text = "invalid input";
                return false;
            }
            else
            {
                label_Confirm_password.Text = "";
            }
            return true;
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
            Records C40 = new Records();
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

        private void button11_Click(object sender, EventArgs e)
        {
            bool validation = Validation();
            //if all inputs are true proceed to database
            if (validation)
            {
                try
                {
                    string q = string.Format("insert into EMPLOYEE values('{0}', '{1}', '{2}', '{3}', '{4}', 'General', 1 ,'{5}')",
                        firstName.Text, lastName.Text, Salary.Text, password.Text, email.Text, phoneNumber.Text);
                    List<string> list = new List<string>();
                    DBController db = new DBController();
                    if (db.OpenConnection())
                    {
                        MySqlCommand cmd = new MySqlCommand(q, db.connection);
                        cmd.ExecuteNonQuery();
                        db.CloseConnection();
                    }

                    label_State.Text = "Employee is Added Successfully";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}

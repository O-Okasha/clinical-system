using clinical_system_N.models;
using MySql.Data.MySqlClient;
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
    public partial class Add_Doctor : Form
    {
        public Add_Doctor()
        {
            InitializeComponent();
        }

        private bool isValid_name(string inp)
        {
            Regex check = new Regex(@"^?([a-zA-Z])$");
            bool valid = check.IsMatch(inp);
            //Console.WriteLine(valid);
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
            valid = check.IsMatch(licsenceNumber.Text);
            if (licsenceNumber.Text == "" || valid == false)
            {
                label_National_ID.ForeColor = Color.Red;
                label_National_ID.Text = "invalid input";
                return false;
            }
            else
            {
                label_National_ID.Text = "";
            }
            if (salary.Text == "" || !isValid_name(salary.Text))
            {
                label_City.ForeColor = Color.Red;
                label_City.Text = "invalid input";
                return false;
            }
            else
            {
                label_City.Text = "";
            }
            if (specialization.Text == "" || valid == false)
            {
                label_Blood_Type.ForeColor = Color.Red;
                label_Blood_Type.Text = "invalid input";
                return false;
            }
            else
            {
                label_Blood_Type.Text = "";
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

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_doctor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validation = Validation();
            //if all inputs are true proceed to database
            if (validation)
            {
                try
                {
                    var x = Guid.NewGuid().ToString();
                    DBController db = new DBController();
                    string q = string.Format("INSERT INTO EMPLOYEE VALUES('{0}', '{1}', {2}, '{3}', '{4}', '{5}', 'Doctor', '{6}', '{7}')",
                        firstName.Text, lastName.Text, salary.Text, password.Text, email.Text, x, phoneNumber.Text);
                    if (db.OpenConnection())
                    {
                        MySqlCommand cmd = new MySqlCommand(q, db.connection);
                        cmd.ExecuteNonQuery();
                        db.CloseConnection();
                    }
                    string emp = "";
                    q = string.Format("select EMPLOYEE_NUMBER from EMPLOYEE where EMAIL = {0}", email.Text);
                    if (db.OpenConnection())
                    {
                        MySqlCommand cmd = new MySqlCommand(q, db.connection);
                        MySqlDataReader dataReader = cmd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            emp = dataReader["EMPLOYEE_NUMBER"].ToString();
                        }
                        dataReader.Close();
                        db.CloseConnection();
                    }
                    q = string.Format("INSERT INTO DOCTOR VALUES('{0}', '{1}', {2}, '{3}', '{4}')",
                       licsenceNumber.Text, emp, specialization.Text, address.Text);
                    if (db.OpenConnection())
                    {
                        MySqlCommand cmd = new MySqlCommand(q, db.connection);
                        cmd.ExecuteNonQuery();
                        db.CloseConnection();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Hide();
                AdminSettings C27 = new AdminSettings();
                C27.Show();
            }
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
            Records C29 = new Records();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool Date_time = false;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Date_time = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

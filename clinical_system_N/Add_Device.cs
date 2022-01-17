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
    public partial class Add_Device : Form
    {
        public Add_Device()
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
            // Device Name Validation
            if (deviceName.Text == "" || !isValid_name(deviceName.Text))
            {
                label_Device_Name.ForeColor = Color.Red;
                label_Device_Name.Text = "invalid input";
                return false;
            }
            else
            {
                label_Device_Name.Text = "";
            }
            //Company name Validation
            if (companyName.Text == "" || !isValid_name(companyName.Text))
            {
                label_Company_Name.ForeColor = Color.Red;
                label_Company_Name.Text = "invalid input";
                return false;
            }
            else
            {
                label_Company_Name.Text = "";
            }
            //Version Number Validation
            if (version.Text == "")
            {
                label_Version_Number.ForeColor = Color.Red;
                label_Version_Number.Text = "invalid input";
                return false;
            }
            else
            {
                label_Version_Number.Text = "";
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
            Add_Doctor C26 = new Add_Doctor();
            C26.Show();

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
            OrthopedicUnit_Calender C23 = new OrthopedicUnit_Calender();
            C23.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Records C24 = new Records();
            C24.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Finance C25 = new Finance();
            C25.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings C36 = new AdminSettings();
            C36.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            bool validation = Validation();
            //if all inputs are true proceed to database
            if (validation)
            {
                var x = Guid.NewGuid().ToString();
                DBController db = new DBController();
                try
                {
                    string q = string.Format("insert into MACHINES values('never', '{0}', '{1}', '{2}', {3} )",
                        deviceName.Text, companyName.Text, version.Text, x);
                    if (db.OpenConnection())
                    {
                        MySqlCommand cmd = new MySqlCommand(q, db.connection);
                        cmd.ExecuteNonQuery();
                        db.CloseConnection();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                label_state.Text = "Device Added Successfully";
            }
        }
    }
}

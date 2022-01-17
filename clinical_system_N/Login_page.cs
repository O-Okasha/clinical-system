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
    public partial class login_page : Form
    {
        public login_page()
        {
            InitializeComponent();
        }

        private bool Validation()
        {
            //Email Validation
            Regex check = new Regex(@"^?([A-Za-z0-9]{3,20})\@?([A-Za-z]{3,10}).?(com)$");
            bool valid = check.IsMatch(email.Text);
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
            //password validation
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
            return true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validation = Validation();
            if (validation)
            {
                this.Hide();
                OrthopedicUnit_Calender C1 = new OrthopedicUnit_Calender();
                C1.Show();
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

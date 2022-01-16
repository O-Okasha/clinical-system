using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinical_system_N.models
{
    internal class Doctor
    {
        public string Id { get; set; }
        public string Name { get; set; }
        private string Password { get; set; }
        private string Email { get; set; }
        private ClinicType clinic { get; set; }

        Doctor(string email, string password)
        {
            Email = email;
            Password = password;

            DBController db = new DBController();

            try
            {
                string q = string.Format("select SPECIALIZATION, EMPLOYEE.EMPLOYEE_NUMBER, F_NAME, L_NAME from DOCTOR, EMPLOYEE where (DOCTOR.EMPLOYEE_NUMBER = EMPLOYEE.EMPLOYEE_NUMBER) and (EMPLOYEE.EMAIL = {0}) ", email);
                string emp = " ";
                string spc = " ";
                string fname = " ";
                string lname = " ";
                if (db.OpenConnection())
                {
                   
                    MySqlCommand cmd = new MySqlCommand(q, db.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        emp = dataReader["EMPLOYEE_NUMBER"].ToString().Trim();
                        spc = dataReader["SPECIALIZATION"].ToString().Trim();
                        fname = dataReader["F_NAME"].ToString().Trim();
                        lname = dataReader["L_NAME"].ToString().Trim();
                    }
                    dataReader.Close();
                    db.CloseConnection();
                }
                Id = emp;
                Name = fname + ' ' + lname;
                if (spc == "ORTHO")
                {
                    clinic = ClinicType.ortho;
                }
                else
                {
                    clinic = ClinicType.physio;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

    }
}

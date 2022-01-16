using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace clinical_system_N.models
{
    internal class DBController
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBController()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "CLINCALSYSTEM";
            uid = "root";
            password = "mysqlpassword";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 0)
                {
                    MessageBox.Show("Cannot connect to server.");
                }
                if (ex.Number == 1045)
                {
                    MessageBox.Show("Invalid Credentials.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
                return false;
            }
        }

    
        public bool CloseConnection()
        {
            try { 
                connection.Close();
                return true;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Create Update Delete
        public void CUD(CrudType type, string table, List<String> values, string condition = "")
        {
            string query = QueryBuilder(type, table, values, condition = "");

            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Process failed: " + ex.Message);
                }
            }
        }

        private String QueryBuilder(CrudType type, string table, List<String> values, string condition = "")
        {
            StringBuilder sb = new StringBuilder();
            if (type == CrudType.insert)
            {
                sb.Append(string.Format("insert into {0} values(", table));
                sb.AppendJoin(",", values);
                sb.Append(")");
                return sb.ToString();
            }
            else if (type == CrudType.update)
            {
                sb.Append(string.Format("update {0} ", table));
                sb.AppendJoin(",", values);
                sb.Append(string.Format("where {0}", condition));
                return sb.ToString();
            }
            else
            {
                sb.Append(string.Format("delete from {0} where ", table));
                sb.Append(condition);
                return sb.ToString();
            }

        }


    }
}

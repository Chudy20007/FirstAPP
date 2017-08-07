using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class LoginForm : Form
    {
        private DatabaseNameLabel Form1Handler;
        public LoginForm()
        {
            InitializeComponent();
            loadDatabases(IntegratedSecurityCheckBox);
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            Database_generator DataBaseGeneratorForm = new Database_generator(this);
            DataBaseGeneratorForm.Show();
            
        }


        private void loadDatabases(CheckBox IntegratedSecurity)
        {
            using (var con = new SqlConnection("Data Source=DESKTOP-QPOCJ0M; User ID=admin; Password=admin; Integrated Security=False"))//+IntegratedSecurity.Checked))
            {

                try
                {
                    con.Open();
                }

                catch
                {
                    MessageBox.Show("Can't connected to the server!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(1);
                }
             
                DataTable databases = con.GetSchema("Databases");
                foreach (DataRow database in databases.Rows)
                {
                    string databaseName = database.Field<string>("database_name");
                    short dbID = database.Field<short>("dbid");
                    DateTime creationDate = database.Field<DateTime>("create_date");

                    if (databaseName != "master" && databaseName != "model" && databaseName != "msdb" && databaseName != "tempdb" && databaseName != "ReportServer" && databaseName != "ReportServerTempDB")
                        DatabaseComboBox.Items.Add(databaseName);

                }
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Database_generator DatabaseGeneratorFormHandler = new Database_generator(this);
        }

        public string getIntegratedSecurityValue()
        {
            return IntegratedSecurityCheckBox.Checked.ToString();
        }

        private void IntegratedSecurityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            switch(IntegratedSecurityCheckBox.Checked)
            {
                case true:
                    {
                        LoginTextBox.Enabled = false;                      
                        PasswordTextBox.Enabled = false;
                        LoginTextBox.BackColor = Color.SlateGray;
                        PasswordTextBox.BackColor = Color.SlateGray;
                        break;
                    }

                case false:
                    {
                        LoginTextBox.Enabled = true;
                        PasswordTextBox.Enabled = true;
                        LoginTextBox.BackColor = Color.White;
                        PasswordTextBox.BackColor = Color.White;
                        break;
                    }

            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (DatabaseComboBox.Text.Length == 0)
            {
                MessageBox.Show("Select a database!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Form fc = Application.OpenForms["DatabaseNameLabel"];
            if (fc != null)
            {
                MessageBox.Show("You are logged!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((LoginTextBox.TextLength==0 || PasswordTextBox.TextLength==0) && IntegratedSecurityCheckBox.Checked == false)
            {
                MessageBox.Show("Incorrect login or password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
                DatabaseMethods.LogIn(LoginTextBox.Text, PasswordTextBox.Text, DatabaseComboBox.SelectedItem.ToString(), IntegratedSecurityCheckBox.Checked.ToString());

      
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class UserRegistration : Form
    {
        private string DatabaseName;
        private string LoggedUser;
        private string IntegratedSecurityValue;
        public UserRegistration(string DatabaseName, string LoggedUser, string IntegratedSecurityValue)
        {
            InitializeComponent();
            this.IntegratedSecurityValue = IntegratedSecurityValue;
            this.LoggedUser = LoggedUser;
            this.DatabaseName = DatabaseName;
        }

        private void UserRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form UserPanel = Application.OpenForms["DatabaseNameLabel"];
            UserPanel.Show();
        }

        private void UserCreate_Click(object sender, EventArgs e)
        {
            var DBConnection = DatabaseMethods.getDBConnection(DatabaseName, IntegratedSecurityValue);
            if (DatabaseMethods.CheckFormValues(UserLoginTextBox.Text, UserPasswordTextBox.Text,"Users"))
            {
               if(!DatabaseMethods.CheckIfRowExist(UserLoginTextBox.Text, DatabaseName, "False", "Users"))
                DatabaseMethods.CreateUser(UserLoginTextBox.Text, UserPasswordTextBox.Text, DatabaseName, "False");
            }
        }
    }
}

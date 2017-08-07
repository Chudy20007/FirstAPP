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
    public partial class PositionRegistration : Form
    {
        private string DatabaseName;
        private string LoggedUser;
        private string IntegratedSecurityValue;
        public PositionRegistration(string DatabaseName, string LoggedUser, string IntegratedSecurityValue)
        {
            InitializeComponent();
            this.IntegratedSecurityValue = IntegratedSecurityValue;
            this.LoggedUser = LoggedUser;
            this.DatabaseName = DatabaseName;
        }

        private void PositionCreate_Click(object sender, EventArgs e)
        {
            var DBConnection = DatabaseMethods.getDBConnection(DatabaseName, IntegratedSecurityValue);
            if (DatabaseMethods.CheckFormValues(PositionNameTextBox.Text,"","Positions"))
            {
                if (!DatabaseMethods.CheckIfRowExist(PositionNameTextBox.Text, DatabaseName, "False", "Positions"))
                    DatabaseMethods.CreatePosition(PositionNameTextBox.Text, DatabaseName, "False");
            }
        }

        private void PositionRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form UserPanel = Application.OpenForms["DatabaseNameLabel"];
            UserPanel.Show();
        }
    }
}

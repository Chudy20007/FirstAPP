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
    public partial class Database_generator : Form
    {
        private LoginForm Form1Handler;
        public Database_generator(LoginForm Form1)
        {
           
            InitializeComponent();

            Form1Handler = Form1;

        }

        private void CreateDatabaseButton_Click(object sender, EventArgs e)
        {
            string IntegratesSecurityValue=this.IntegratedSecurityCheckBox.Checked.ToString();
           var DB = DatabaseMethods.CreateDB("DESKTOP-QPOCJ0M", DatabaseNameTextBox.Text,IntegratesSecurityValue,LoginTextBox.Text,PasswordTextBox.Text);
            
            this.Close();
           // DatabaseMethods.ShowTable(DB);
            
        }

        private void CreateRelations(DatabaseContext Database)
        { 
}

        private void IntegratedSecurityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            switch (IntegratedSecurityCheckBox.Checked)
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

        private void CreateDatabaseButton_MouseHover(object sender, EventArgs e)
        {
           
        }
    }
}

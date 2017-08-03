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
    public partial class DatabaseNameLabel : Form
    {


        private string DatabaseName;
        private string LoggedUser;
        private BindingSource bindingSource1 = new BindingSource();
        public DatabaseNameLabel(string LoggedUser, string DatabaseName)
        {
            InitializeComponent();
            this.LoggedUser = LoggedUser;
            this.DatabaseName = DatabaseName;
            LoggedUserLabel.Text ="Logged user: "+LoggedUser;
            DatabaseNameLabel2.Text ="Database name: "+DatabaseName;
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseMethods.ClearTreeView(treeView1);
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            this.Refresh();
            //dataGridView1.DataSource
            bindingSource1 = DatabaseMethods.GetDataToTable("Users", DatabaseName);
            dataGridView1.AutoSize = true;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Visible = true;
            
        }

        private void tableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DatabaseMethods.ClearTreeView(treeView1);
            //dataGridView1.DataSource
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.ClearSelection();
            dataGridView1.Refresh();
            this.Refresh();
            bindingSource1 = DatabaseMethods.GetDataToTable("Employees", DatabaseName);
            dataGridView1.AutoSize = true;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Visible = true;
        }

        private void tableToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DatabaseMethods.ClearTreeView(treeView1);
            //dataGridView1.DataSource
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            this.Refresh();
            bindingSource1 = DatabaseMethods.GetDataToTable("Bonuses", DatabaseName);
            dataGridView1.AutoSize = true;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Visible = true;
        }

        private void tableToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DatabaseMethods.ClearTreeView(treeView1);
            //dataGridView1.DataSource
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            this.Refresh();


            bindingSource1 = DatabaseMethods.GetDataToTable("Positions", DatabaseName);
            dataGridView1.AutoSize = true;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Visible = true;
        }

        private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
           dataGridView1.Visible = false;
           DatabaseMethods.ClearTreeView(treeView1);
           DatabaseMethods.GetDataToTreeView(treeView1,"Users", DatabaseName);     
        }

        private void treeViewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            DatabaseMethods.ClearTreeView(treeView1);
            DatabaseMethods.GetDataToTreeView(treeView1, "Employees", DatabaseName);          
        }

        private void treeViewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            DatabaseMethods.ClearTreeView(treeView1);
            DatabaseMethods.GetDataToTreeView(treeView1, "Bonuses", DatabaseName);
        }

        private void treeViewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            DatabaseMethods.ClearTreeView(treeView1);
            DatabaseMethods.GetDataToTreeView(treeView1, "Positions", DatabaseName);
        }
    }
}

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
        public event EventHandler Click;
        List<TreeView> TreeListViews = new List<TreeView>();
        List<TabPage> TreeListTabPages = new List<TabPage>();
        List<TabPage> DataGridTabPages = new List<TabPage>();
        List<BindingSource> BindingSourceViews = new List<BindingSource>();
        List<DataGridView> DataGridViews = new List<DataGridView>();
        private string DatabaseName;
        private string LoggedUser;
        private BindingSource bindingSource1 = new BindingSource();
        public DatabaseNameLabel(string LoggedUser, string DatabaseName)
        {
            InitializeComponent();
            this.LoggedUser = LoggedUser;
            this.DatabaseName = DatabaseName;
            if (LoggedUser == null)
                LoggedUserLabel.Text = "Logged user: admin";
            else
                LoggedUserLabel.Text = "Logged user: " + LoggedUser;

            DatabaseNameLabel2.Text = "Database name: " + DatabaseName;
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViews.Add(new DataGridView());
            BindingSourceViews.Add(new BindingSource());
            BindingSourceViews[BindingSourceViews.Count - 1] = DatabaseMethods.GetDataToTable("Users", DatabaseName);
            DataGridViews[DataGridViews.Count - 1].DataSource = BindingSourceViews[BindingSourceViews.Count - 1];
            DataGridViews[DataGridViews.Count - 1].AutoSize = true;
            DataGridViews[DataGridViews.Count - 1].AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridTabPages.Add(new TabPage("TB - Users"));
            DataGridTabPages[DataGridTabPages.Count - 1].Controls.Add(DataGridViews[DataGridViews.Count - 1]);
            DataTabs.Controls.Add(DataGridTabPages[DataGridTabPages.Count - 1]);
            DataTabs.SelectedTab = DataTabs.TabPages[DataTabs.TabPages.Count - 1];
        }

        private void tableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataGridViews.Add(new DataGridView());
            BindingSourceViews.Add(new BindingSource());
            BindingSourceViews[BindingSourceViews.Count - 1] = DatabaseMethods.GetDataToTable("Employees", DatabaseName);
            DataGridViews[DataGridViews.Count - 1].DataSource = BindingSourceViews[BindingSourceViews.Count - 1];
            DataGridViews[DataGridViews.Count - 1].AutoSize = true;
            DataGridTabPages.Add(new TabPage("TB - Employees"));
            DataGridTabPages[DataGridTabPages.Count - 1].Controls.Add(DataGridViews[DataGridViews.Count - 1]);
            DataTabs.Controls.Add(DataGridTabPages[DataGridTabPages.Count - 1]);
            DataTabs.SelectedTab = DataTabs.TabPages[DataTabs.TabPages.Count - 1];
        }

        private void tableToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataGridViews.Add(new DataGridView());
            BindingSourceViews.Add(new BindingSource());
            BindingSourceViews[BindingSourceViews.Count - 1] = DatabaseMethods.GetDataToTable("Bonuses", DatabaseName);
            DataGridViews[DataGridViews.Count - 1].DataSource = BindingSourceViews[BindingSourceViews.Count - 1];
            DataGridViews[DataGridViews.Count - 1].AutoSize = true;
            DataGridTabPages.Add(new TabPage("TB - Bonuses"));
            DataGridTabPages[DataGridTabPages.Count - 1].Controls.Add(DataGridViews[DataGridViews.Count - 1]);
            DataTabs.Controls.Add(DataGridTabPages[DataGridTabPages.Count - 1]);
            DataTabs.SelectedTab = DataTabs.TabPages[DataTabs.TabPages.Count - 1];
        }

        private void tableToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DataGridViews.Add(new DataGridView());
            BindingSourceViews.Add(new BindingSource());
            BindingSourceViews[BindingSourceViews.Count - 1] = DatabaseMethods.GetDataToTable("Positions", DatabaseName);
            DataGridViews[DataGridViews.Count - 1].DataSource = BindingSourceViews[BindingSourceViews.Count - 1];
            DataGridViews[DataGridViews.Count - 1].AutoSize = true;
            DataGridTabPages.Add(new TabPage("TB - Positions"));
            DataGridTabPages[DataGridTabPages.Count - 1].Controls.Add(DataGridViews[DataGridViews.Count - 1]);
            DataTabs.Controls.Add(DataGridTabPages[DataGridTabPages.Count - 1]);
            DataTabs.SelectedTab = DataTabs.TabPages[DataTabs.TabPages.Count - 1];
        }

        private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            TreeListTabPages.Add(DatabaseMethods.CreateNewTabPage("TLV - Users"));
            TreeListViews.Add(new TreeView());
            DatabaseMethods.ClearTreeView(TreeListViews[TreeListViews.Count - 1]);
            DatabaseMethods.GetDataToTreeView(TreeListViews[TreeListViews.Count - 1], "Users", DatabaseName, DataTabs);
            TreeListTabPages[TreeListTabPages.Count - 1].Controls.Add(TreeListViews[TreeListViews.Count - 1]);
            DataTabs.Controls.Add(TreeListTabPages[TreeListTabPages.Count - 1]);
            DataTabs.SelectedTab = DataTabs.TabPages[DataTabs.TabPages.Count - 1];
        }

        private void treeViewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            TreeListTabPages.Add(DatabaseMethods.CreateNewTabPage("TLV - Employees"));
            TreeListViews.Add(new TreeView());
            DatabaseMethods.ClearTreeView(TreeListViews[TreeListViews.Count - 1]);
            DatabaseMethods.GetDataToTreeView(TreeListViews[TreeListViews.Count - 1], "Employees", DatabaseName, DataTabs);
            TreeListTabPages[TreeListTabPages.Count - 1].Controls.Add(TreeListViews[TreeListViews.Count - 1]);
            DataTabs.Controls.Add(TreeListTabPages[TreeListTabPages.Count - 1]);
            DataTabs.SelectedTab = DataTabs.TabPages[DataTabs.TabPages.Count - 1];
        }

        private void treeViewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            TreeListTabPages.Add(DatabaseMethods.CreateNewTabPage("TLV - Bonuses"));
            TreeListViews.Add(new TreeView());
            DatabaseMethods.ClearTreeView(TreeListViews[TreeListViews.Count - 1]);
            DatabaseMethods.GetDataToTreeView(TreeListViews[TreeListViews.Count - 1], "Bonuses", DatabaseName, DataTabs);
            TreeListTabPages[TreeListTabPages.Count - 1].Controls.Add(TreeListViews[TreeListViews.Count - 1]);
            DataTabs.Controls.Add(TreeListTabPages[TreeListTabPages.Count - 1]);
            DataTabs.SelectedTab = DataTabs.TabPages[DataTabs.TabPages.Count - 1];
        }

        private void treeViewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            TreeListTabPages.Add(DatabaseMethods.CreateNewTabPage("TLV - Positions"));
            TreeListViews.Add(new TreeView());
            DatabaseMethods.ClearTreeView(TreeListViews[TreeListViews.Count - 1]);
            DatabaseMethods.GetDataToTreeView(TreeListViews[TreeListViews.Count - 1], "Positions", DatabaseName, DataTabs);
            TreeListTabPages[TreeListTabPages.Count - 1].Controls.Add(TreeListViews[TreeListViews.Count - 1]);
            DataTabs.Controls.Add(TreeListTabPages[TreeListTabPages.Count - 1]);
            DataTabs.SelectedTab = DataTabs.TabPages[DataTabs.TabPages.Count - 1];
        }

        private void DataTabs_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }

        private void DataTabs_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenu TabPagesContextMenu = new ContextMenu();
                TabPagesContextMenu.MenuItems.Add("Refresh", new EventHandler(Refresh_Click));
                TabPagesContextMenu.MenuItems.Add("Close", new EventHandler(Close_Click));
                //cm.SourceControl.Location = new Point(e.X, e.Y);
                TabPagesContextMenu.Show(DataTabs, new Point(e.X, e.Y));




            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            // Insert code to handle Click event.
        }

        private void Close_Click(object sender, EventArgs e)
        {
            int i = 0;
            do
            {

                if (Cursor.Position.X < DataTabs.GetTabRect(i).Width + DataTabs.GetTabRect(i).X && Cursor.Position.X >= DataTabs.GetTabRect(i).X)
                {
                    DataTabs.TabPages[i].Dispose();
                    break;
                }

                i++;
            } while (i < DataTabs.TabPages.Count);
        }

    }
    
}

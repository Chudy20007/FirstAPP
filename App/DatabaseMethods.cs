using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
   public static class DatabaseMethods
    {
        public static DatabaseContext CreateDB(string dbsource, string DatabaseName, string IntegratedSecurityValue,string login, string password)
        {
            string connectionString=null;

            if (CheckDatabaseName(DatabaseName))
            {                
                return null;
            }

           
            switch (IntegratedSecurityValue)
            {

                case "True":
                {
                       // MessageBox.Show(IntegratedSecurityValue);
                  connectionString = "Data Source=DESKTOP-QPOCJ0M;" + "Initial Catalog=" + DatabaseName + "; User ID=admin;Password='admin'; Integrated Security=False;";
                   break;
                }

                case "False":
                {
                        //MessageBox.Show(IntegratedSecurityValue);
                        if (!CheckFormValues(login, password))
                        {
                            return null;
                        }
                        connectionString = "Data Source=DESKTOP-QPOCJ0M;" + "Initial Catalog=" + DatabaseName + "; User ID=admin; Password=admin; Integrated Security=False;";
                        break;
                }

            }
            
            DatabaseContext CreatedDB = new DatabaseContext(connectionString);
            CreatedDB.CreateDatabase();
            MessageBox.Show("Database created successfully!","Success!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            CreateUser(login, password, DatabaseName, IntegratedSecurityValue);
            
           
            return CreatedDB;
        }

        public static bool CheckDatabaseName(string DatabaseName)
        {
            if (DatabaseName.Length == 0)
            {
                MessageBox.Show("Database name is incorrect!", "Incorrect DB name!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            var connectionString = "Data Source=DESKTOP-QPOCJ0M;" + "Initial Catalog=" + DatabaseName + "; User ID=admin;Password='admin'; Trusted_Connection=False";
            DatabaseContext CreatedDB = new DatabaseContext(connectionString);

            if (CreatedDB.DatabaseExists())
            {
                MessageBox.Show("Database already exists!!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;


        }

        public static bool CheckFormValues(string login, string password)
        {
            bool isCorrect=true;
            Regex LoginRegex = new Regex(@"^[a-z]{4,}$"); ;
            Regex PasswordRegex = new Regex(@"^[a-z]{4,}$");

            if (login.Length==0 && password.Length==0)
                isCorrect=false;
            if(!LoginRegex.IsMatch(login))
                isCorrect = false;
            if(!PasswordRegex.IsMatch(password))
                isCorrect = false;
            if (!isCorrect)
            MessageBox.Show("Check login or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return isCorrect;

        }

        
       

        public static void ShowTable (DatabaseContext DB, DataGridView DGV)
        {

            var queryShow = from Employees in DB.BonusesTable select Employees;

            foreach (var item in queryShow)
            {
                //DGV.S
            }

        }

        public static DatabaseContext getDBConnection(string DatabaseName,string IntegratedSecurityValue)
        {
            string connectionString = null;
            switch (IntegratedSecurityValue)
            {

                case "True":
                    {
                        //MessageBox.Show(IntegratedSecurityValue);
                        connectionString = "Data Source=DESKTOP-QPOCJ0M;" + "Initial Catalog=" + DatabaseName + "; User ID=admin;Password='admin'; Integrated Security=False";
                        break;
                    }

                case "False":
                    {
                        //MessageBox.Show(IntegratedSecurityValue);
                        connectionString = "Data Source=DESKTOP-QPOCJ0M;"+"User ID=admin; Password=admin;" + "Initial Catalog=" + DatabaseName + "; Integrated Security=False;";
                        break;
                    }

            }
            DatabaseContext db = new DatabaseContext(connectionString);
            return db;
        }

        public static void LogIn(string login, string password, string DatabaseName, string IntegratedSecurityValue)
        {

            var DBContext = getDBConnection(DatabaseName, IntegratedSecurityValue);
            DBContext.Connection.Open();
            var UserTable=DBContext.UsersTable.ToList();

            switch (IntegratedSecurityValue)
            {
                case "True":
                    {
                        MessageBox.Show("User are exists!");
                        DatabaseNameLabel UserPanel = new DatabaseNameLabel(login, DatabaseName);
                        Form LoginForm = Application.OpenForms["LoginForm"];
                        LoginForm.Visible = false;
                        UserPanel.Show();
                        break;
                    }

                case "False":
                    {
                        Users result = UserTable.Find(x => x.UserLogin == login && x.UserPassword == password);
                        if (result != null)
                        {
                            MessageBox.Show("User are exists!");
                            DatabaseNameLabel UserPanel = new DatabaseNameLabel(login,DatabaseName);
                            Form LoginForm = Application.OpenForms["LoginForm"];
                            LoginForm.Visible = false;
                            UserPanel.Show();
                           
                            

                        }
                        else
                            MessageBox.Show("User are not exists!");
                        break;
                    }
            }
           

        }

        public static void CreateUser(string login, string password, string DatabaseName, string IntegratedSecurityValue)
        {
            var DBContext = getDBConnection(DatabaseName, IntegratedSecurityValue);
            
            DBContext.Connection.Open();
            if (IntegratedSecurityValue=="False")
            {
                Users u = new Users();
                Users u1 = new Users();
                u.UserLogin = login;
                u.UserPassword = password;
                DBContext.UsersTable.InsertOnSubmit(u);
                u1.UserLogin = "admin";
                u1.UserPassword = "admin1";
                DBContext.UsersTable.InsertOnSubmit(u1);
            }

            else
            {
                Users u = new Users();
                u.UserLogin = "admin";
                u.UserPassword = "admin1";
                DBContext.UsersTable.InsertOnSubmit(u);
            }
           
            DBContext.SubmitChanges();
            DBContext.Connection.Close();
            DBContext.Dispose();
        }

        public static BindingSource GetDataToTable (string TableName, string DatabaseName)
        {
            
            var DBConnection = DatabaseMethods.getDBConnection(DatabaseName, "False");
            // DataGridView
            

            // BindingSource (used for synchronizing table and grid)
            BindingSource bs = new BindingSource();

            // Set DataSource of BindingSource to table
            switch (TableName)
            {
                case "Employees":
                    {
                        bs.DataSource = DBConnection.EmployessTable;
                        break;
                    }
                case "Bonuses":
                    {
                        bs.DataSource = DBConnection.BonusesTable;
                        break;
                    }
                case "Positions":
                    {
                        bs.DataSource = DBConnection.PositionsTable;
                        break;
                    }

                case "Users":
                    {
                        bs.DataSource = DBConnection.UsersTable;
                        break;
                    }
            }
           

            // Set grid DataSource
            
            return bs;
        }

        //public static BindingSource GetDataToTreeView(string TableName, string DatabaseName)
        //{
        //    var DBConnection = DatabaseMethods.getDBConnection(DatabaseName, "False");
        //    BindingSource bs = new BindingSource();
        //    switch (TableName)
        //    {
        //        case "Employees":
        //            {
        //                bs.DataSource = DBConnection.EmployessTable;
        //                break;
        //            }
        //        case "Bonuses":
        //            {
        //                bs.DataSource = DBConnection.BonusesTable;
        //                break;
        //            }
        //        case "Positions":
        //            {
        //                bs.DataSource = DBConnection.PositionsTable;
        //                break;
        //            }

        //        case "Users":
        //            {
        //                bs.DataSource = DBConnection.UsersTable;
        //                break;
        //            }
        //    }

        //    return bs;
        //}
        public static DataGridView ClearSelectedDataGridView (DataGridView DataGrid)
        {
            DataGrid.DataSource = null;
            return DataGrid;
        }

        public static void ClearTreeView (TreeView SelectedTreeView)
        {
            SelectedTreeView.Visible = false;
            SelectedTreeView.Nodes.Clear();
         
        }

        public static TreeView GetDataToTreeView(TreeView SelectedTreeView, string SelectedTable,string DatabaseName, TabControl DataTabs)
        {
            var DatabaseConnection = DatabaseMethods.getDBConnection(DatabaseName, "False");
            List<TreeNode> NewTreeNode = DatabaseMethods.GetDataToTreeNode(SelectedTable, DatabaseConnection);
            SelectedTreeView.Nodes.AddRange(NewTreeNode.ToArray());
            SelectedTreeView.Visible = true;
            SelectedTreeView.Height = 300;
            SelectedTreeView.Width = 500;
           
            return SelectedTreeView;
        }

        public static TabPage CreateNewTabPage (string TabPageName)
        {
             
            return  new TabPage(TabPageName); 
        }
            
        

        public static List<TreeNode> GetDataToTreeNode(string SelectedTable,DatabaseContext DatabaseConnection)
        {
           
            List<TreeNode> NewTreeNode = new List<TreeNode>();
            switch (SelectedTable)
            {
                case "Employees":
                    {
                        var EmployeeList = DatabaseConnection.PositionsTable.ToList();
                        foreach (var ItemFromList in DatabaseConnection.EmployessTable)
                        {


                            TreeNode Node = new TreeNode();
                            Node.Text = ItemFromList.EmployeeID.ToString();
                            //TreeNode tn2 = new TreeNode("Bonuses");
                            //foreach (var z in x.EmployeeBonuses)
                            //{
                            //    tn2.Nodes.Add(z.AmountBonus.ToString());
                            //    tn2.Nodes.Add(z.PercentageBonus.ToString()+"%");
                            //}
                            Node.Nodes.Add("Name: " + ItemFromList.EmployeeName);
                            Node.Nodes.Add("Surname: " + ItemFromList.EmployeeSurname);
                            var EmployeeTemp = EmployeeList.Where(w => ItemFromList.EmployeePositionID == w.PositionID).ToArray();

                            Node.Nodes.Add("Position: " + EmployeeTemp[0].PositionName);
                            Node.Nodes.Add("Seniority: " + ItemFromList.EmployeeSeniority.ToString());
                            //  tn.Nodes.Add(tn2);
                            NewTreeNode.Add(Node);

                        }
                      
                        break;

                    }


                case "Users":
                            {
                                var UsersList = DatabaseConnection.UsersTable.ToList();
                                foreach (var ItemFromList in UsersList)
                                {
                                TreeNode Node = new TreeNode();
                                Node.Text = ItemFromList.UserID.ToString();

                                Node.Nodes.Add("Login: "+ ItemFromList.UserLogin);
                                Node.Nodes.Add("Password: *******");

                                NewTreeNode.Add(Node);
                                }
                        break;
                    }

                case "Bonuses":
                    {
                        var BonusesList = DatabaseConnection.BonusesTable.ToList();
                        foreach (var ItemFromList in BonusesList)
                        {
                            TreeNode Node = new TreeNode();
                            Node.Text = ItemFromList.BonusID.ToString();

                            Node.Nodes.Add("Amount bonus: "+ ItemFromList.AmountBonus.ToString());
                            Node.Nodes.Add("Percentage bonus: "+ ItemFromList.PercentageBonus.ToString());
                            NewTreeNode.Add(Node);

                        }
                        break;
                    }

                case "Positions":
                    {
                        var PositionsList = DatabaseConnection.PositionsTable.ToList();
                        foreach (var x in PositionsList)
                        {

                            TreeNode Node = new TreeNode();
                            Node.Text = x.PositionID.ToString();

                            Node.Nodes.Add("Position name: " + x.PositionName);
                            NewTreeNode.Add(Node);


                        }
                       
                    break;
                    }

                   

            }
            return NewTreeNode;
        }

       

    }
}

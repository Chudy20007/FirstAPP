using System.Linq;
using System.Data.Linq;
namespace App
{
    public class DatabaseContext: DataContext
    {
        public Table<Employees>EmployessTable;
        public Table<Bonuses>BonusesTable;
        public Table<Positions>PositionsTable;
        public Table<Users> UsersTable;

        //public DatabaseContext(string DataSource,string InitialCatalog,bool IntegratedSecurity):base("Data Source="+DataSource+";"+"Initail Catalog="+InitialCatalog+";"+"IntegratedSecurity="+IntegratedSecurity)
        //{

        //}

        public DatabaseContext(string connection) : base(connection) { }
    }
}

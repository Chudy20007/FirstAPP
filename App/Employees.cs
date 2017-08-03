using System;
using System.Collections.Generic;

using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    [Table(Name ="Employee")]
    public class Employees
    {
        
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int EmployeeID { get; set; }
        [Column][System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Employee surname is required")]
        public string EmployeeSurname { get; set; }
        [Column] [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Employee name is required")]
        public string EmployeeName { get; set; }
        [Column] public int EmployeePositionID { get; set; }
        public virtual List<Bonuses> EmployeeBonuses { get; set; }

        [Column] public int EmployeeSeniority { get; set; }



    }

   

 
}

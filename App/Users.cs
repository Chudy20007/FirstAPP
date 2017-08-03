using System;
using System.Collections.Generic;

using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;
namespace App
{
    [Table(Name = "User")]
    public class Users
    {

        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int UserID { get; set; }
        [Column]
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User surname is required")]
        public string UserLogin { get; set; }
        [Column]
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User name is required")]
        public string UserPassword { get; set; }

    }
}

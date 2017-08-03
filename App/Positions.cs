using System;
using System.Collections.Generic;

using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    [Table(Name = "Positions")]
    public class Positions
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int PositionID { get; set; }
        [Column]
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position name is required")]
        public string PositionName { get; set; }
    }
}

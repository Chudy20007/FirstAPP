using System;
using System.Collections.Generic;

using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;
namespace App
{
    [Table(Name = "Bonuses")]
    public class Bonuses
    {

        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int BonusID { get; set; }
        [Column]
        public int PercentageBonus { get; set; }
        [Column]
        public float AmountBonus { get; set; }
        public virtual Employees Employee { get; set; }

    }

    
}

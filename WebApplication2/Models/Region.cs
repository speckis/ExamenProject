using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace WebApplication2.Models
{
    public class Region
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RegionID { get; set; }
        public string Name { get; set; }
        public int PostalCode { get; set; }

        public virtual ICollection<Register> Register { get; set; }
    }
}

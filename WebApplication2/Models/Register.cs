using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplication2.Models
{
    public class Register
    {
        public int RegisterID { get; set; }
        public int RegionID { get; set; }
        public int UserID { get; set; }

        public virtual Region Region { get; set; }
        public virtual User User { get; set; }  
    }
}

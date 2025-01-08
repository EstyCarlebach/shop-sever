using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class Company
    {
        public int CompId { get; set; }

        public string CompName { get; set; } = null!;

        //public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}

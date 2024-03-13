using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leyer.Data.Entities
{
    class Product
    {
        [Key]
        public int ProductsID { get; set; }
        public int ProductsSerial { get; set; }
        public string Name { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}

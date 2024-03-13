using Leyer.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leyer.Data.MyDbs
{
    class MyDb : DbContext
    {
        public MyDb() : base("name=BloggingContext")
        {

        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

    }
}

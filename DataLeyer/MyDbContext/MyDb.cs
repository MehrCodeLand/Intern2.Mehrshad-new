using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataLeyer.MyDbContext
{
    public partial class MyDb : DbContext
    {
        public MyDb()
            : base("data source=BAT;initial catalog=Intern3;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework providerName= System.Data.SqlClient")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Kala> Kalas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

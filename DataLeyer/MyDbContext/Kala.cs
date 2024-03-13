namespace DataLeyer.MyDbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kala")]
    public partial class Kala
    {
        public int KalaID { get; set; }

        [Required]
        [StringLength(50)]
        public string SerialNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}

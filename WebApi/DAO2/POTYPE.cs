namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("POTYPE")]
    public partial class POTYPE
    {
        [Key]
        [StringLength(20)]
        public string CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCR { get; set; }
    }
}

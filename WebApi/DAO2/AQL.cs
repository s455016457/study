namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AQL")]
    public partial class AQL
    {
        [Key]
        [StringLength(20)]
        public string CODE { get; set; }

        public decimal SAMPLEQTY { get; set; }

        [Required]
        [StringLength(50)]
        public string AQLDESCR { get; set; }
    }
}

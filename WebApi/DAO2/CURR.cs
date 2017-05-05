namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CURR")]
    public partial class CURR
    {
        [Key]
        [StringLength(20)]
        public string CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCR { get; set; }

        public decimal? RATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EFFDATE { get; set; }
    }
}

namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REPACKING")]
    public partial class REPACKING
    {
        [Key]
        [StringLength(20)]
        public string ORISEQNUM { get; set; }

        [Required]
        [StringLength(20)]
        public string WONUM { get; set; }

        [Required]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        public decimal QTY { get; set; }

        [StringLength(500)]
        public string LABELID { get; set; }

        public int COMPLETED { get; set; }

        public DateTime CREATED { get; set; }

        [Required]
        [StringLength(10)]
        public string CREATEDBY { get; set; }
    }
}

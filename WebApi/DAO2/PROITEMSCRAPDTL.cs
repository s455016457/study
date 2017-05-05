namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROITEMSCRAPDTL")]
    public partial class PROITEMSCRAPDTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string PISNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        public decimal SCPQTY { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

        public decimal REPQTY { get; set; }

        [StringLength(100)]
        public string SCRAPREASON { get; set; }

        public DateTime CREATED { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? UPDATESTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEUSER { get; set; }
    }
}

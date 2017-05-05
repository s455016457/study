namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRLSCB")]
    public partial class PRLSCB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string PRLSCNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string WONUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        public decimal SYSQTY { get; set; }

        public decimal? SCQTY { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime CREATED { get; set; }

        [StringLength(20)]
        public string UPDATEUSER { get; set; }

        public DateTime? UPDATESTAMP { get; set; }
    }
}

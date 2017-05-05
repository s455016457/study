namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SRAPPB")]
    public partial class SRAPPB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string SRAPPNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string SINUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string SONUM { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string LOT { get; set; }

        public decimal REJECT { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

        public decimal UPRICE { get; set; }

        public decimal AMOUNT { get; set; }

        [StringLength(200)]
        public string REMARKS { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime CREATED { get; set; }

        public DateTime? UPDATESTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEUSER { get; set; }

        public bool ISSOACCESSORY { get; set; }

        public bool ISREPLENISH { get; set; }

        public decimal REPLENISHQTY { get; set; }
    }
}

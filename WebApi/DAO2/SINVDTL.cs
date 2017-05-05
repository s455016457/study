namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SINVDTL")]
    public partial class SINVDTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string SINUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string SONUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string LOT { get; set; }

        public decimal QTY { get; set; }

        public decimal UPRICE { get; set; }

        [Required]
        [StringLength(5)]
        public string UOM { get; set; }

        public decimal AMOUNT { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        public decimal CUSTOMPRICE { get; set; }

        [StringLength(30)]
        public string CUSPONUM { get; set; }

        [StringLength(30)]
        public string PSNUM { get; set; }

        public int? ISSELECTED { get; set; }

        [StringLength(30)]
        public string SELECTEDUID { get; set; }

        [StringLength(30)]
        public string INVNUM { get; set; }

        public bool ISSOACCESSORY { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long SEQNUM { get; set; }
    }
}

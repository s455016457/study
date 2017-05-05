namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRDTL")]
    public partial class PRDTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string PRNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

        public decimal QTY { get; set; }

        public decimal? ORDQTY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ADPODATE { get; set; }

        [Required]
        [StringLength(500)]
        public string PURPOSE { get; set; }

        [StringLength(100)]
        public string VENID { get; set; }

        public int? LEADTIME { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RECDATE { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RESPONSEDATE { get; set; }

        public DateTime? CREATED { get; set; }

        public int STATUS { get; set; }

        public decimal POQTY { get; set; }

        [StringLength(50)]
        public string SUITENUM { get; set; }

        [StringLength(200)]
        public string SUITENAME { get; set; }

        public decimal? SUITEQTY { get; set; }

        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        [StringLength(20)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}

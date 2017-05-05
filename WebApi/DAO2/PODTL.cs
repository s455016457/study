namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PODTL")]
    public partial class PODTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string PONUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string LOT { get; set; }

        [StringLength(50)]
        public string VENITEMNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime RECVDATE { get; set; }

        public decimal UPRICE { get; set; }

        public decimal? EXQTY { get; set; }

        [StringLength(10)]
        public string EXUOM { get; set; }

        public decimal QTY { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

        public decimal? AMOUNT { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(20)]
        public string PRNUM { get; set; }

        public decimal GRNQTY { get; set; }

        public decimal REJECTQTY { get; set; }

        public int STATUS { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CLOSEDDATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REPLYRECVDATE { get; set; }

        public decimal? EXTUPRICE { get; set; }

        public decimal? EXTEXPENSE { get; set; }

        [StringLength(50)]
        public string SUITENUM { get; set; }

        [StringLength(200)]
        public string SUITENAME { get; set; }

        public decimal? SUITEQTY { get; set; }
    }
}

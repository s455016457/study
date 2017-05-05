namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OUTSTANDINGWO")]
    public partial class OUTSTANDINGWO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string WONUM { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime WODATE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string WOSRC { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string WOTYPE { get; set; }

        [StringLength(20)]
        public string SONUM { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string ITEMNUM { get; set; }

        [StringLength(20)]
        public string LOT { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "smalldatetime")]
        public DateTime PLANBEGDATE { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "smalldatetime")]
        public DateTime PLANENDDATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SUBMITDATE { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(20)]
        public string WORKSHOP { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CLOSED { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal WOQTY { get; set; }

        public decimal? OUTQTY { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal INQTY { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(10)]
        public string UOM { get; set; }
    }
}

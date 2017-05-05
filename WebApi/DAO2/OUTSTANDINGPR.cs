namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OUTSTANDINGPR")]
    public partial class OUTSTANDINGPR
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string PRNUM { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "smalldatetime")]
        public DateTime PRDATE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string PROPOSER { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string DEPTID { get; set; }

        [StringLength(20)]
        public string PROJECT { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(10)]
        public string UOM { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal QTY { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "smalldatetime")]
        public DateTime ADPODATE { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(500)]
        public string PURPOSE { get; set; }

        [StringLength(20)]
        public string VENID { get; set; }

        public int? LEADTIME { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RECDATE { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal POQTY { get; set; }

        public decimal? OUTQTY { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STATUS { get; set; }

        [StringLength(10)]
        public string EXUOM { get; set; }

        public decimal? EXRATE { get; set; }

        public decimal? EXQTY { get; set; }

        [StringLength(100)]
        public string ITEMDESCR { get; set; }
    }
}

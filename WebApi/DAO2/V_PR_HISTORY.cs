namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_PR_HISTORY
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

        [StringLength(500)]
        public string REMARK { get; set; }

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

        public decimal? ORDQTY { get; set; }

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
        public string PRDTLREMARK { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RESPONSEDATE { get; set; }

        public DateTime? CREATED { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(100)]
        public string ITEMDESCR { get; set; }

        [StringLength(100)]
        public string SPEC { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(100)]
        public string DEPTNAME { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(100)]
        public string NAME { get; set; }
    }
}

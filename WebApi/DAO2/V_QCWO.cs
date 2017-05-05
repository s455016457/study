namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_QCWO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string QCNUM { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string DOCNUM { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string WORKPROC { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string WORKSHOP { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string PROLINE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(20)]
        public string INSPECTOR { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(20)]
        public string WONUM { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal QTY { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal CHECKQTY { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal SAMPLEQTY { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal DEFECTQTY { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(10)]
        public string DEFECTHANDLING { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(10)]
        public string HANDLING { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [Key]
        [Column(Order = 14)]
        public DateTime WODATE { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(20)]
        public string WOSRC { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(10)]
        public string WOTYPE { get; set; }

        [StringLength(20)]
        public string SONUM { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(20)]
        public string ITEMNUM { get; set; }

        [StringLength(20)]
        public string LOT { get; set; }

        [Key]
        [Column(Order = 19)]
        public decimal WOQTY { get; set; }

        [Key]
        [Column(Order = 20, TypeName = "smalldatetime")]
        public DateTime PLANBEGDATE { get; set; }

        [Key]
        [Column(Order = 21, TypeName = "smalldatetime")]
        public DateTime PLANENDDATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SUBMITDATE { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(20)]
        public string WOWORKSHOP { get; set; }

        [StringLength(500)]
        public string WOREMARK { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CLOSED { get; set; }

        [Key]
        [Column(Order = 24)]
        [StringLength(50)]
        public string WORKPROCDESCR { get; set; }

        [StringLength(20)]
        public string QCTEAM { get; set; }

        [StringLength(100)]
        public string QCTEAMDESCR { get; set; }
    }
}

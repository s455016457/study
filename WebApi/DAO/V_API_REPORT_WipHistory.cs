namespace DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_API_REPORT_WipHistory
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string WIPNUM { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "smalldatetime")]
        public DateTime WIPDATE { get; set; }

        public int? COMPLETED { get; set; }

        [StringLength(10)]
        public string WIPTYPE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string LOCID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string WONUM { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string LOT { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal QTY { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(6)]
        public string COMPLETEDDESCR { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MFGDATE { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(10)]
        public string DOCTYPE { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(500)]
        public string ITEMDESCR { get; set; }

        [StringLength(500)]
        public string SPEC { get; set; }

        [StringLength(50)]
        public string WAREHOUSEDESCR { get; set; }

        [StringLength(100)]
        public string CREATEDUSERNAME { get; set; }

        [StringLength(10)]
        public string UOM { get; set; }

        [StringLength(10)]
        public string PROLINE { get; set; }

        [StringLength(30)]
        public string PROLINEDESCR { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(6)]
        public string WFSTATUSDESCR { get; set; }

        [StringLength(500)]
        public string LABELID { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(500)]
        public string LABELDESCR { get; set; }
    }
}

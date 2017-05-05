namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_STOCKADJUSTDTL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string SANUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string REFNUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string LOT { get; set; }

        [StringLength(20)]
        public string REASON { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal CURRQTY { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal ADJQTY { get; set; }

        public decimal? MQTY { get; set; }

        [StringLength(10)]
        public string UOM { get; set; }

        [StringLength(500)]
        public string LABELID { get; set; }

        [StringLength(50)]
        public string CUSTOMLABELID { get; set; }

        public DateTime? MFGDATE { get; set; }

        public int? GUAPERIOD { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime CREATED { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? UPDATESTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEUSER { get; set; }

        [StringLength(500)]
        public string ITEMDESCR { get; set; }

        [StringLength(500)]
        public string SPEC { get; set; }
    }
}

namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_MIDTL
    {
        [Key]
        [Column(Order = 0)]
        public decimal QTY { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string WONUM { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "smalldatetime")]
        public DateTime MIDATE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string MITYPE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string MINUM { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(20)]
        public string PART { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal PARTQTY { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(10)]
        public string UOM { get; set; }

        [StringLength(1003)]
        public string REMARK { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public decimal? ISSQTY { get; set; }

        [StringLength(100)]
        public string ITEMDESCR { get; set; }

        [StringLength(30)]
        public string MITYPEDESCR { get; set; }
    }
}

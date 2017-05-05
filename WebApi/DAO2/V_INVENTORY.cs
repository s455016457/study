namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_INVENTORY
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string LOCID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string REFNUM { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string LOT { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal QTY { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string UOM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MFGDATE { get; set; }

        public int? GUAPERIOD { get; set; }

        [StringLength(500)]
        public string LABELID { get; set; }

        [StringLength(50)]
        public string CUSTOMLABELID { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(2)]
        public string STATUS { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime UPDATESTAMP { get; set; }

        [StringLength(500)]
        public string ITEMDESCR { get; set; }

        [StringLength(500)]
        public string SPEC { get; set; }

        [StringLength(10)]
        public string ITEMGRP { get; set; }

        [StringLength(10)]
        public string ITEMTYPE { get; set; }

        [StringLength(20)]
        public string WONUM { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string WAREHOUSEDESCR { get; set; }
    }
}

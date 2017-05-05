namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MESWOA")]
    public partial class MESWOA
    {
        [Key]
        [StringLength(20)]
        public string WONUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime WODATE { get; set; }

        [Required]
        [StringLength(10)]
        public string WOTYPE { get; set; }

        [StringLength(50)]
        public string WOTYPE2 { get; set; }

        [StringLength(20)]
        public string SONUM { get; set; }

        [Required]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [StringLength(20)]
        public string ECNNUM { get; set; }

        [StringLength(20)]
        public string SCHEMENUM { get; set; }

        [StringLength(20)]
        public string LOT { get; set; }

        [StringLength(50)]
        public string SOITEMNUM { get; set; }

        public decimal QTY { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PLANBEGDATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PLANENDDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string PRODUCTIONLINE { get; set; }

        [StringLength(3000)]
        public string REMARKS { get; set; }

        public decimal WIPQTY { get; set; }

        public int CLOSED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CLOSEDDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }
    }
}

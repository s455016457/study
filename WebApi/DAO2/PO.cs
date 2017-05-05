namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PO")]
    public partial class PO
    {
        [Key]
        [StringLength(20)]
        public string PONUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [StringLength(10)]
        public string POTYPE { get; set; }

        [StringLength(10)]
        public string REV { get; set; }

        [StringLength(20)]
        public string WONUM { get; set; }

        [StringLength(20)]
        public string PROJECT { get; set; }

        [Required]
        [StringLength(20)]
        public string VENID { get; set; }

        [Required]
        [StringLength(10)]
        public string CURR { get; set; }

        public decimal RATE { get; set; }

        [StringLength(20)]
        public string INVTYPE { get; set; }

        public decimal TAXRATE { get; set; }

        [StringLength(20)]
        public string BUYER { get; set; }

        [Required]
        [StringLength(20)]
        public string PAYTERM { get; set; }

        [Required]
        [StringLength(20)]
        public string PAYMETHOD { get; set; }

        [Required]
        [StringLength(20)]
        public string TRADETERM { get; set; }

        [StringLength(200)]
        public string SHIPTO { get; set; }

        [StringLength(200)]
        public string SHIPMARK { get; set; }

        [StringLength(20)]
        public string VIA { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? AMOUNT { get; set; }

        public int? CLOSED { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CLOSEDDATE { get; set; }

        [StringLength(30)]
        public string DEPTID { get; set; }

        [StringLength(1000)]
        public string COMMENTS { get; set; }

        public decimal? INSURE { get; set; }

        public decimal? HANDLE { get; set; }

        public decimal? DELIVERYCHRG { get; set; }

        public decimal? MISCHRG { get; set; }

        [StringLength(200)]
        public string MISCHRGTIT { get; set; }

        [StringLength(20)]
        public string MISCACC { get; set; }

        public decimal? TOTALQTY { get; set; }

        public int EXECSTATE { get; set; }

        public DateTime? EXECSTATEUPDATEDSTAMP { get; set; }

        public virtual BUYER BUYER1 { get; set; }

        public virtual INVTYPE INVTYPE1 { get; set; }

        public virtual PAYMETHOD PAYMETHOD1 { get; set; }

        public virtual PAYTERM PAYTERM1 { get; set; }
    }
}

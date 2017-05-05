namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SR")]
    public partial class SR
    {
        [Key]
        [StringLength(20)]
        public string SRNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string CUSID { get; set; }

        [StringLength(30)]
        public string CUSREF { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        [StringLength(20)]
        public string SONUM { get; set; }

        public decimal? AMOUNT { get; set; }

        public int? POST { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        public int? VNUM { get; set; }

        [StringLength(20)]
        public string INVTYPE { get; set; }

        public decimal? TAXRATE { get; set; }

        [StringLength(20)]
        public string CURR { get; set; }

        public decimal? RATE { get; set; }

        [StringLength(20)]
        public string DEPTID { get; set; }

        [StringLength(30)]
        public string SALESREGION { get; set; }

        [StringLength(30)]
        public string SALESREP { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }
    }
}

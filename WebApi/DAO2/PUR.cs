namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PUR")]
    public partial class PUR
    {
        [Key]
        [StringLength(20)]
        public string PURNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string VENID { get; set; }

        [StringLength(20)]
        public string CURR { get; set; }

        public decimal? RATE { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        public decimal? AMOUNT { get; set; }

        public int? POST { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        [StringLength(2)]
        public string DTYPE { get; set; }

        public int? VNUM { get; set; }

        [StringLength(20)]
        public string INVTYPE { get; set; }

        public decimal? TAXRATE { get; set; }

        [StringLength(30)]
        public string GRNACC { get; set; }

        public DateTime? CHECKEDSTAMP { get; set; }

        [StringLength(20)]
        public string CHECKEDUSER { get; set; }

        public int? ISCHECKED { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(30)]
        public string DEPTID { get; set; }

        [StringLength(20)]
        public string BUYER { get; set; }

        [StringLength(20)]
        public string REFPONUM { get; set; }
    }
}

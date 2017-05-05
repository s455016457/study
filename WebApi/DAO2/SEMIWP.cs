namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SEMIWP")]
    public partial class SEMIWP
    {
        [Key]
        [StringLength(20)]
        public string SWNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [StringLength(10)]
        public string SWTYPE { get; set; }

        [Required]
        [StringLength(20)]
        public string LOCID { get; set; }

        [Required]
        [StringLength(20)]
        public string WONUM { get; set; }

        [Required]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

        [Required]
        [StringLength(10)]
        public string WORKPROC { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        public decimal? TOTALQTY { get; set; }

        public int? COMPLETED { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }
    }
}

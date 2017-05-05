namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MI")]
    public partial class MI
    {
        [Key]
        [StringLength(20)]
        public string MINUM { get; set; }

        [Required]
        [StringLength(10)]
        public string MITYPE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime MIDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string WONUM { get; set; }

        [Required]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        public decimal QTY { get; set; }

        [StringLength(20)]
        public string DEPTID { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        public int? CLOSED { get; set; }

        [StringLength(20)]
        public string SCHEMENUM { get; set; }
    }
}

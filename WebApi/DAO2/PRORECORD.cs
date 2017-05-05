namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRORECORD")]
    public partial class PRORECORD
    {
        [Key]
        [StringLength(20)]
        public string PRORECNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PRORECDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string WONUM { get; set; }

        [Required]
        [StringLength(20)]
        public string WORKSHOP { get; set; }

        [Required]
        [StringLength(20)]
        public string PROLINE { get; set; }

        [Required]
        [StringLength(20)]
        public string WORKPROC { get; set; }

        public int? LABOR { get; set; }

        public decimal? LABORHOUR { get; set; }

        [StringLength(2)]
        public string STARTHOUR { get; set; }

        [StringLength(2)]
        public string STARTMINUTE { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime CREATED { get; set; }

        [StringLength(20)]
        public string UPDATEUSER { get; set; }

        public DateTime? UPDATESTAMP { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        [StringLength(20)]
        public string PREVWORKPROC { get; set; }

        [StringLength(100)]
        public string EXTRA1 { get; set; }

        [StringLength(100)]
        public string EXTRA2 { get; set; }
    }
}

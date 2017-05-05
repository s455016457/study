namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRAPLY")]
    public partial class CRAPLY
    {
        [Key]
        [StringLength(20)]
        public string CANUM { get; set; }

        [Required]
        [StringLength(20)]
        public string CUSID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        public decimal? OUTSOAMT { get; set; }

        public decimal? CLBAL { get; set; }

        public decimal? CRDLIMIT { get; set; }

        public decimal? OLDXLIMIT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? OLDXDATE { get; set; }

        public decimal NEWXLIMIT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime NEWXDATE { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        public DateTime? CREATEDTIME { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public int STATUS { get; set; }

        public decimal? NEWCREDITLIMIT { get; set; }

        public int? ISCRLMT { get; set; }

        public int? ISCRLMTSO { get; set; }
    }
}

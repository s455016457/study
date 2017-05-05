namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DISAMA")]
    public partial class DISAMA
    {
        [Key]
        [StringLength(20)]
        public string DISAMNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DISAMDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string WONUM { get; set; }

        [Required]
        [StringLength(20)]
        public string DEPTID { get; set; }

        [Required]
        [StringLength(20)]
        public string LOCID { get; set; }

        [Required]
        [StringLength(100)]
        public string REMARKS { get; set; }

        public decimal TOTALQTY { get; set; }

        public int? COMPLETED { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(20)]
        public string UPDATEUSER { get; set; }

        public DateTime? UPDATESTAMP { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }
    }
}

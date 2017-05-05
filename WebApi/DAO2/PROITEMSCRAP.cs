namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROITEMSCRAP")]
    public partial class PROITEMSCRAP
    {
        [Key]
        [StringLength(20)]
        public string PISNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string WONUM { get; set; }

        [Required]
        [StringLength(20)]
        public string WORKSHOP { get; set; }

        [Required]
        [StringLength(20)]
        public string WORKPROC { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        public DateTime CREATED { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? UPDATESTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEUSER { get; set; }

        [StringLength(2)]
        public string DTYPE { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        [StringLength(50)]
        public string FGITEMNUM { get; set; }
    }
}

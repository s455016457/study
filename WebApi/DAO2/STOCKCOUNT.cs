namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STOCKCOUNT")]
    public partial class STOCKCOUNT
    {
        [Key]
        [StringLength(20)]
        public string SCNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime SCDATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CUTDATE { get; set; }

        [Required]
        [StringLength(2)]
        public string SCTYPE { get; set; }

        [Required]
        [StringLength(10)]
        public string LOCID { get; set; }

        [StringLength(500)]
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
    }
}

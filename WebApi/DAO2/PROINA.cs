namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROINA")]
    public partial class PROINA
    {
        [Key]
        [StringLength(20)]
        public string PROINNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PROINDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string WONUM { get; set; }

        [Required]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Required]
        [StringLength(20)]
        public string PROLINE { get; set; }

        [Required]
        [StringLength(20)]
        public string WORKPROC { get; set; }

        [Required]
        [StringLength(20)]
        public string TEAM { get; set; }

        [Required]
        [StringLength(20)]
        public string DEVICE { get; set; }

        [StringLength(500)]
        public string REMARKS { get; set; }

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

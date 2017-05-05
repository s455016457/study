namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SALFRT")]
    public partial class SALFRT
    {
        [Key]
        [StringLength(20)]
        public string SFNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(20)]
        public string PROJECT { get; set; }

        public int? CLOSED { get; set; }

        [StringLength(50)]
        public string CREATEDBY { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? VALIDITYDATE { get; set; }
    }
}

namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ECNTEA")]
    public partial class ECNTEA
    {
        [Key]
        [StringLength(20)]
        public string ECNTENUM { get; set; }

        public DateTime ECNTEDATE { get; set; }

        [Required]
        [StringLength(50)]
        public string ECNTETYPE { get; set; }

        [StringLength(500)]
        public string REMARKS { get; set; }

        [StringLength(30)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(30)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }
    }
}

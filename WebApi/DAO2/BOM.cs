namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BOM")]
    public partial class BOM
    {
        [Key]
        [StringLength(50)]
        public string ANCESTOR { get; set; }

        [StringLength(20)]
        public string ECNNUM { get; set; }

        [StringLength(20)]
        public string DOCNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RELEASEDATE { get; set; }

        [Required]
        [StringLength(10)]
        public string REV { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        [StringLength(200)]
        public string ADDONS { get; set; }

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

        [StringLength(20)]
        public string WORKPROC { get; set; }
    }
}

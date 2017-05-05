namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STOCKADJUST")]
    public partial class STOCKADJUST
    {
        [Key]
        [StringLength(20)]
        public string SANUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime SADATE { get; set; }

        [Required]
        [StringLength(20)]
        public string LOCID { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        public int COMPLETED { get; set; }

        public DateTime CREATED { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? UPDATESTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEUSER { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        [StringLength(10)]
        public string SATYPE { get; set; }
    }
}

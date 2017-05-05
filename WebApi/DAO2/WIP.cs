namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WIP")]
    public partial class WIP
    {
        [Key]
        [StringLength(20)]
        public string WIPNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime WIPDATE { get; set; }

        [StringLength(10)]
        public string WIPTYPE { get; set; }

        [Required]
        [StringLength(20)]
        public string LOCID { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        public int? COMPLETED { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        public virtual WIPTYPE WIPTYPE1 { get; set; }
    }
}

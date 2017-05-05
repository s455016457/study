namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ST")]
    public partial class ST
    {
        [Key]
        [StringLength(20)]
        public string STNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [StringLength(20)]
        public string DEPTID { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string OPERATOR { get; set; }

        public int? COMPLETED { get; set; }

        [StringLength(50)]
        public string CONFIRMBY { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }
    }
}

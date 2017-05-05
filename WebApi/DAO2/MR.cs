namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MR")]
    public partial class MR
    {
        [Key]
        [StringLength(20)]
        public string MRNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime MRDATE { get; set; }

        [StringLength(2)]
        public string MRTYPE { get; set; }

        [StringLength(20)]
        public string WONUM { get; set; }

        [StringLength(20)]
        public string DEPTID { get; set; }

        [StringLength(20)]
        public string LOCID { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

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

        [StringLength(50)]
        public string FGITEMNUM { get; set; }
    }
}

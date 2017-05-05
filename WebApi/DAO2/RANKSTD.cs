namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RANKSTD")]
    public partial class RANKSTD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string RANKCODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string RANKTYPE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime EFFDATE { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        [StringLength(30)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(30)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}

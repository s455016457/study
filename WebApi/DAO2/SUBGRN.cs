namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SUBGRN")]
    public partial class SUBGRN
    {
        [Key]
        [StringLength(20)]
        public string SGNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string CUSID { get; set; }

        [StringLength(20)]
        public string SONUM { get; set; }

        [StringLength(20)]
        public string YOURREF { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        [StringLength(30)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(30)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}

namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GRN")]
    public partial class GRN
    {
        [Key]
        [StringLength(20)]
        public string GRNNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string VENID { get; set; }

        [StringLength(20)]
        public string PONUM { get; set; }

        [StringLength(20)]
        public string YOURREF { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? AMOUNT { get; set; }

        public int? POST { get; set; }

        public int? COMPLETED { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        [StringLength(2)]
        public string GTYPE { get; set; }

        [StringLength(2)]
        public string DTYPE { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        public int? VNUM { get; set; }

        [StringLength(30)]
        public string GRNACC { get; set; }

        public DateTime? CHECKEDSTAMP { get; set; }

        [StringLength(20)]
        public string CHECKEDUSER { get; set; }

        public int? ISCHECKED { get; set; }
    }
}

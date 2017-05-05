namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OTHGRN")]
    public partial class OTHGRN
    {
        [Key]
        [StringLength(20)]
        public string OGNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string VENID { get; set; }

        [StringLength(20)]
        public string YOURREF { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATED { get; set; }

        public int? FCONFIRM { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        [StringLength(30)]
        public string DEPTID { get; set; }

        [StringLength(20)]
        public string PONUM { get; set; }

        [StringLength(20)]
        public string DOCTYPE { get; set; }
    }
}

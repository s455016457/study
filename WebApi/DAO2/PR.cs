namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PR")]
    public partial class PR
    {
        [Key]
        [StringLength(20)]
        public string PRNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PRDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string PROPOSER { get; set; }

        [Required]
        [StringLength(20)]
        public string DEPTID { get; set; }

        [StringLength(20)]
        public string PROJECT { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public int STATUS { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        [StringLength(2)]
        public string PRTYPE { get; set; }

        [StringLength(20)]
        public string PURREP { get; set; }

        [StringLength(20)]
        public string EXECDEPTID { get; set; }

        [StringLength(100)]
        public string TOTALQTY { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }
    }
}

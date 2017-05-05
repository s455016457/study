namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRSYSA")]
    public partial class PRSYSA
    {
        [Key]
        [StringLength(30)]
        public string PRSYSNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PRSYSDATE { get; set; }

        [Required]
        [StringLength(30)]
        public string DEPTID { get; set; }

        [Required]
        [StringLength(10)]
        public string SYSTYPE { get; set; }

        [StringLength(500)]
        public string REMARKS { get; set; }

        public int ISCONFIRMED { get; set; }

        [StringLength(50)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        [StringLength(50)]
        public string UPDATEDBY { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        [StringLength(30)]
        public string CUSVEN { get; set; }

        [StringLength(20)]
        public string CURR { get; set; }
    }
}

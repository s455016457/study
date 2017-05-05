namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SRAPPA")]
    public partial class SRAPPA
    {
        [Key]
        [StringLength(20)]
        public string SRAPPNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime SRAPPDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string CUSID { get; set; }

        [Required]
        [StringLength(20)]
        public string DEPTID { get; set; }

        [Required]
        [StringLength(20)]
        public string SALESREP { get; set; }

        [Required]
        [StringLength(20)]
        public string CURR { get; set; }

        public decimal RATE { get; set; }

        [Required]
        [StringLength(20)]
        public string INVTYPE { get; set; }

        public decimal TAXRATE { get; set; }

        public decimal TOTALAMOUNT { get; set; }

        [StringLength(500)]
        public string REFUNDREASON { get; set; }

        [StringLength(500)]
        public string REMARKS { get; set; }

        public int ISCONFIRMED { get; set; }

        [StringLength(20)]
        public string SRNUM { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime CREATED { get; set; }

        public DateTime? UPDATESTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEUSER { get; set; }

        [StringLength(30)]
        public string SALESREGION { get; set; }
    }
}

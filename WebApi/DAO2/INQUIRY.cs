namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INQUIRY")]
    public partial class INQUIRY
    {
        [Key]
        [StringLength(20)]
        public string ISNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ISDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string VENID { get; set; }

        [Required]
        [StringLength(20)]
        public string BUYER { get; set; }

        [Required]
        [StringLength(20)]
        public string PAYMETHOD { get; set; }

        [Required]
        [StringLength(20)]
        public string PAYTERM { get; set; }

        [Required]
        [StringLength(20)]
        public string TRADETERM { get; set; }

        [Required]
        [StringLength(20)]
        public string CURR { get; set; }

        public decimal RATE { get; set; }

        public decimal TAXRATE { get; set; }

        [StringLength(20)]
        public string SHIPVIA { get; set; }

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

        public bool COMPLETED { get; set; }

        public DateTime? COMPLETEDSTAMP { get; set; }

        [StringLength(20)]
        public string COMPLETEDUSER { get; set; }
    }
}

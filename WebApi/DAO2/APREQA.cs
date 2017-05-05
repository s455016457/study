namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APREQA")]
    public partial class APREQA
    {
        [Key]
        [StringLength(20)]
        public string AQNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string VENID { get; set; }

        [Required]
        [StringLength(20)]
        public string CURR { get; set; }

        public decimal RATE { get; set; }

        [Required]
        [StringLength(20)]
        public string INVTYPE { get; set; }

        public decimal TAXRATE { get; set; }

        public decimal AMOUNT { get; set; }

        [Required]
        [StringLength(500)]
        public string REMARKS { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime CREATED { get; set; }

        [StringLength(20)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }
    }
}

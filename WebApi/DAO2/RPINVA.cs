namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RPINVA")]
    public partial class RPINVA
    {
        [Key]
        [StringLength(20)]
        public string RPINVNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime RPINVDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string LOCID { get; set; }

        [Required]
        [StringLength(20)]
        public string CUSID { get; set; }

        [Required]
        [StringLength(20)]
        public string CURR { get; set; }

        public decimal RATE { get; set; }

        [StringLength(30)]
        public string INVTYPE { get; set; }

        public decimal? TAXRATE { get; set; }

        [Required]
        [StringLength(20)]
        public string PAYTERM { get; set; }

        [Required]
        [StringLength(20)]
        public string PAYMETHOD { get; set; }

        [Required]
        [StringLength(20)]
        public string TRADETERM { get; set; }

        [StringLength(50)]
        public string VIA { get; set; }

        [StringLength(50)]
        public string EXPNUM { get; set; }

        [StringLength(500)]
        public string REMARKS { get; set; }

        [StringLength(20)]
        public string SALESREP { get; set; }

        [Required]
        [StringLength(20)]
        public string SALESREGION { get; set; }

        public decimal TOTALQTY { get; set; }

        public decimal TOTALAMOUNT { get; set; }

        public int COMPLETED { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEDBY { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}

namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RPINVB")]
    public partial class RPINVB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string RPINVNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string REFNUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string LOT { get; set; }

        public decimal QTY { get; set; }

        [Required]
        [StringLength(20)]
        public string UOM { get; set; }

        public decimal UPRICE { get; set; }

        public decimal AMOUNT { get; set; }

        [StringLength(500)]
        public string REMARKS { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEDBY { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}

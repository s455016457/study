namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SOACYB")]
    public partial class SOACYB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string SONUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string LOT { get; set; }

        public decimal UPRICE { get; set; }

        public decimal QTY { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

        public decimal AMOUNT { get; set; }

        [StringLength(200)]
        public string REMARKS { get; set; }

        [StringLength(30)]
        public string CREATEDUSER { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        [StringLength(30)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }

        public decimal SIQTY { get; set; }

        public decimal REJECTQTY { get; set; }

        public bool CLOSED { get; set; }

        public DateTime? CLOSEDSTAMP { get; set; }

        public decimal REPLENISHQTY { get; set; }
    }
}

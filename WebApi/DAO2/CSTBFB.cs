namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSTBFB")]
    public partial class CSTBFB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string CSTBFNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string ITEMNUM { get; set; }

        public decimal QTY { get; set; }

        public decimal UPRICE { get; set; }

        public decimal AMOUNT { get; set; }

        [StringLength(500)]
        public string REMARKS { get; set; }

        [StringLength(30)]
        public string CREATEDUSER { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        [StringLength(30)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}

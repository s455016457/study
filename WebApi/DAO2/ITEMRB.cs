namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ITEMRB")]
    public partial class ITEMRB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string IREPNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

        [Required]
        [StringLength(200)]
        public string REMARKS { get; set; }

        [Required]
        [StringLength(100)]
        public string EXTRA1 { get; set; }

        [Required]
        [StringLength(100)]
        public string EXTRA2 { get; set; }

        [Required]
        [StringLength(30)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(30)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}

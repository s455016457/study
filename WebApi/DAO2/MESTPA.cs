namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MESTPA")]
    public partial class MESTPA
    {
        [Key]
        [StringLength(20)]
        public string MESTPNUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime MESTPDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string WONUM { get; set; }

        [Required]
        [StringLength(20)]
        public string PRODUCTIONLINE { get; set; }

        [Required]
        [StringLength(500)]
        public string LABELID { get; set; }

        [StringLength(30)]
        public string DEVNUM { get; set; }

        public decimal TOTALINPUTQTY { get; set; }

        public decimal TOTALOUTPUTQTY { get; set; }

        [Required]
        [StringLength(500)]
        public string REMARKS { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}

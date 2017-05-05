namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BEGITEMSBAL")]
    public partial class BEGITEMSBAL
    {
        [Key]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        public decimal QTY { get; set; }

        public decimal UPRICE { get; set; }

        public decimal AMOUNT { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

        [StringLength(20)]
        public string INVACC { get; set; }

        public DateTime CREATED { get; set; }
    }
}

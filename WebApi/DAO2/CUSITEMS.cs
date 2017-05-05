namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CUSITEMS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CUSID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Required]
        [StringLength(50)]
        public string CUSITEMNUM { get; set; }

        public decimal UPRICE { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

        public int LEADTIME { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [StringLength(500)]
        public string LABELNUM { get; set; }
    }
}

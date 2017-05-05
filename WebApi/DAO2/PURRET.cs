namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PURRET")]
    public partial class PURRET
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string PRTNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string PONUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string LOT { get; set; }

        public decimal EXREJECT { get; set; }

        public decimal UPRICE { get; set; }

        [Required]
        [StringLength(10)]
        public string EXUOM { get; set; }

        public decimal REJECT { get; set; }

        [Required]
        [StringLength(10)]
        public string UOM { get; set; }

        public decimal AMOUNT { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        public decimal? REJECTEDQTY { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        [StringLength(20)]
        public string DRN { get; set; }

        [StringLength(30)]
        public string INVACCNUM { get; set; }

        public int? ISREPLENISH { get; set; }

        public decimal? REPLENISHQTY { get; set; }

        [StringLength(20)]
        public string PURAPNUM { get; set; }
    }
}

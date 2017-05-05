namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BKFOTA")]
    public partial class BKFOTA
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FPERIOD { get; set; }

        [StringLength(20)]
        public string DOCNUM { get; set; }

        [StringLength(20)]
        public string REFNUM { get; set; }

        public DateTime? IDATE { get; set; }

        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [StringLength(10)]
        public string UOM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string LOCID { get; set; }

        public decimal? QTY { get; set; }

        public decimal? UPRICE { get; set; }

        public decimal? AMOUNT { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }
    }
}

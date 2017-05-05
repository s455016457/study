namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SCCSTA")]
    public partial class SCCSTA
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FPERIOD { get; set; }

        [Required]
        [StringLength(30)]
        public string VENID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string PONUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string FGITEMNUM { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [StringLength(20)]
        public string UOM { get; set; }

        public decimal? LASTUPRICE { get; set; }

        public decimal? LASTQTY { get; set; }

        public decimal? LASTAMOUNT { get; set; }

        public decimal? MIQTY { get; set; }

        public decimal? MIPRICE { get; set; }

        public decimal? MIAMOUNT { get; set; }

        public decimal? GRNQTY1 { get; set; }

        public decimal? GRNQTY2 { get; set; }

        public decimal? GRNQTY3 { get; set; }

        public decimal? GRNQTY4 { get; set; }

        public decimal? GRNQTY { get; set; }

        public decimal? GRNPRICE { get; set; }

        public decimal? GRNAMOUNT { get; set; }

        public decimal? DOSAGE { get; set; }

        public decimal? SCRAPQTY { get; set; }

        public decimal? UPRICE { get; set; }

        public decimal? QTY { get; set; }

        public decimal? AMOUNT { get; set; }

        public int? CLOSED { get; set; }

        public int? ISBKFLUSH { get; set; }
    }
}

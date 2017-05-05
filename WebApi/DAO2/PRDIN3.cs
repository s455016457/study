namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRDIN3
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FPERIOD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string WONUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [Required]
        [StringLength(20)]
        public string UOM { get; set; }

        public decimal LASTUPRICE { get; set; }

        public decimal LASTQTY { get; set; }

        public decimal LASTAMOUNT { get; set; }

        public decimal UPRICE { get; set; }

        public decimal QTY { get; set; }

        public decimal AMOUNT { get; set; }

        public int ISOPEN { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string BKFHLOCID { get; set; }

        public decimal? DOSAGE { get; set; }
    }
}

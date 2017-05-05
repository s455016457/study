namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRDOTB")]
    public partial class PRDOTB
    {
        public long ID { get; set; }

        public int FPERIOD { get; set; }

        [StringLength(20)]
        public string DOCNUM { get; set; }

        public DateTime? IDATE { get; set; }

        [StringLength(20)]
        public string WONUM { get; set; }

        [StringLength(50)]
        public string WOITEMNUM { get; set; }

        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [StringLength(10)]
        public string UOM { get; set; }

        public decimal? QTY1 { get; set; }

        public decimal? QTY2 { get; set; }

        public decimal? QTY3 { get; set; }

        public decimal? QTY4 { get; set; }

        public decimal? UPRICE { get; set; }

        public decimal? AMOUNT { get; set; }

        [StringLength(20)]
        public string DEPTID { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        [StringLength(20)]
        public string CUSID { get; set; }

        public decimal? SOUPRICE { get; set; }

        public decimal? SOAMOUNT { get; set; }

        public decimal? SOTAXRATE { get; set; }

        public decimal? NONETAXSOUPRICE { get; set; }

        public decimal? NONETAXSOAMOUNT { get; set; }

        [StringLength(30)]
        public string REWONUM { get; set; }

        [StringLength(30)]
        public string RESONUM { get; set; }

        [StringLength(30)]
        public string LOCID { get; set; }

        public bool? HASPRICE { get; set; }
    }
}

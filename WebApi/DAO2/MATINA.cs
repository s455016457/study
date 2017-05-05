namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MATINA")]
    public partial class MATINA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FPERIOD { get; set; }

        [StringLength(20)]
        public string DOCNUM { get; set; }

        [StringLength(20)]
        public string PONUM { get; set; }

        [StringLength(20)]
        public string VENID { get; set; }

        public DateTime? IDATE { get; set; }

        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [StringLength(10)]
        public string UOM { get; set; }

        public decimal? QTY { get; set; }

        public decimal? UPRICE { get; set; }

        public decimal? TAXRATE { get; set; }

        public decimal? AMOUNT { get; set; }

        public decimal? NONETAXUPRICE { get; set; }

        public decimal? NONETAXAMOUNT { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        [StringLength(10)]
        public string DTYPE { get; set; }

        [StringLength(50)]
        public string SCITEMNUM { get; set; }

        public decimal? SCUPRICE { get; set; }

        public int? ISCHECKED { get; set; }

        public DateTime? CHECKEDSTAMP { get; set; }

        [StringLength(30)]
        public string CHECKEDUSER { get; set; }

        public int? POST { get; set; }

        [StringLength(30)]
        public string VNUM { get; set; }

        [StringLength(30)]
        public string INVNUM { get; set; }

        [StringLength(30)]
        public string AQNUM { get; set; }

        [StringLength(30)]
        public string WFSTATUS { get; set; }

        public decimal? SCRAPQTY { get; set; }
    }
}

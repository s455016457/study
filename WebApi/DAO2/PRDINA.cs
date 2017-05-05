namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRDINA")]
    public partial class PRDINA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FPERIOD { get; set; }

        [StringLength(20)]
        public string DOCNUM { get; set; }

        [StringLength(20)]
        public string WONUM { get; set; }

        [StringLength(20)]
        public string VENID { get; set; }

        public DateTime? IDATE { get; set; }

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

        public decimal? TAXRATE { get; set; }

        public decimal? NONETAXUPRICE { get; set; }

        public decimal? NONETAXAMOUNT { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        [StringLength(100)]
        public string LOCID { get; set; }
    }
}

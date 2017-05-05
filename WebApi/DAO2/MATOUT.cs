namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MATOUT")]
    public partial class MATOUT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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

        public decimal? QTY { get; set; }

        public decimal? UPRICE { get; set; }

        public decimal? AMOUNT { get; set; }

        [StringLength(20)]
        public string DEPTID { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }
    }
}

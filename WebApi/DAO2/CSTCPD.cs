namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSTCPD")]
    public partial class CSTCPD
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FPERIOD { get; set; }

        [StringLength(20)]
        public string PONUM { get; set; }

        [StringLength(50)]
        public string ITEMNUM { get; set; }

        public decimal? QTY { get; set; }

        public decimal? UPRICE { get; set; }

        public decimal? AMOUNT { get; set; }

        public decimal? WIPQTY { get; set; }

        public decimal? WIPUPRICE { get; set; }

        public decimal? WIPAMOUNT { get; set; }

        public decimal? SIUPRICE { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }
    }
}

namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRDRTA")]
    public partial class PRDRTA
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FPERIOD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [StringLength(20)]
        public string UOM { get; set; }

        public decimal? MQTY { get; set; }

        public decimal? YQTY { get; set; }

        public decimal? LYAVGUCOST { get; set; }

        public decimal? YPUCOST { get; set; }

        public decimal? MACTUCOST { get; set; }

        public decimal? YACTAVGUCOST { get; set; }

        public decimal? MLTAMT { get; set; }

        public decimal? MYPAMT { get; set; }

        public decimal? MACTAMT { get; set; }

        public decimal? YLACTAMT { get; set; }

        public decimal? YYPAMT { get; set; }

        public decimal? YYACTAMT { get; set; }
    }
}

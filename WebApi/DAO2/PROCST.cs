namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROCST")]
    public partial class PROCST
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FPERIOD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string WONUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [StringLength(20)]
        public string SONUM { get; set; }

        public decimal? WOQTY { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string PARTNUM { get; set; }

        [StringLength(20)]
        public string UOM { get; set; }

        public decimal? OPENWIP { get; set; }

        public decimal? OPENUPRICE { get; set; }

        public decimal? OPENAMT { get; set; }

        public decimal? PERIODIN { get; set; }

        public decimal? UPRICE { get; set; }

        public decimal? AMOUNT { get; set; }

        public decimal? FG1 { get; set; }

        public decimal? FG2 { get; set; }

        public decimal? FG3 { get; set; }

        public decimal? FG4 { get; set; }

        public decimal? FGQTY { get; set; }

        public decimal? FGUPRICE { get; set; }

        public decimal? FGAMOUNT { get; set; }

        public decimal? ENDWIP { get; set; }

        public decimal? ENDWIPUPRICE { get; set; }

        public decimal? ENDWIPAMT { get; set; }

        public decimal? DOSAGE { get; set; }

        public decimal? SCRAPQTY { get; set; }

        public int? ISREWORK { get; set; }

        public int? CLOSED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CLOSEDDATE { get; set; }

        public int? ISBKFLSH { get; set; }

        public decimal? TOTALFG1 { get; set; }

        public decimal? TOTALFG2 { get; set; }

        public decimal? TOTALFG3 { get; set; }

        public decimal? TOTALFG4 { get; set; }

        public decimal? TOTALFGQTY { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(30)]
        public string BKFHLOCID { get; set; }

        public int ISUNLIMITED { get; set; }
    }
}

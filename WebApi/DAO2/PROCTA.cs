namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROCTA")]
    public partial class PROCTA
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FPERIOD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string WONUM { get; set; }

        [StringLength(20)]
        public string SONUM { get; set; }

        [Required]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        public decimal? OPENQTY { get; set; }

        public decimal? OPENAMT { get; set; }

        public decimal? QTY { get; set; }

        public decimal? AMOUNT { get; set; }

        public decimal? FGQTY { get; set; }

        public decimal? FGQTY2 { get; set; }

        public decimal? SCRAPQTY { get; set; }

        public decimal? FGAMOUNT { get; set; }

        public decimal? ENDWIPQTY { get; set; }

        public decimal? ENDWIPAMT { get; set; }

        public decimal? STDWRK { get; set; }

        public decimal? STDWRKRATE { get; set; }

        public decimal? STDWRK2 { get; set; }

        public decimal? STDWRK2RATE { get; set; }

        public decimal? WORKHOUR { get; set; }

        public decimal? WORKHOUR2 { get; set; }

        public decimal? TOTALWRKHR { get; set; }

        public decimal? TOTALWRKHR2 { get; set; }

        public decimal? TOTALLABORCOST { get; set; }

        public decimal? TOTALFACOVRHAD { get; set; }

        public decimal? TOTALFUELCOST { get; set; }

        public decimal? LABORCOST { get; set; }

        public decimal? FACOVRHAD { get; set; }

        public decimal? FUELCOST { get; set; }

        public decimal? TOTALCOST { get; set; }

        public decimal? UPRICE { get; set; }

        [StringLength(100)]
        public string PROLINE { get; set; }

        public int? ISREWORK { get; set; }

        public int? CLOSED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CLOSEDDATE { get; set; }

        public decimal? DIFFAMOUNT { get; set; }

        public decimal? MAINMATCOST { get; set; }

        public decimal? BKFHCOST { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string BKFHLOCID { get; set; }

        public decimal? TOTALSTDLABORCOST { get; set; }

        public decimal? TOTALSTDFACOVRHAD { get; set; }

        public decimal? TOTALSTDFUELCOST { get; set; }

        public decimal? TOTALSTDCOST { get; set; }

        public decimal? STDUPRICE { get; set; }

        public decimal ADJUSTAMOUNT { get; set; }

        [StringLength(20)]
        public string WOTYPE { get; set; }

        [StringLength(50)]
        public string WOTYPENAME { get; set; }

        [StringLength(50)]
        public string WOTYPE2 { get; set; }

        [StringLength(50)]
        public string PROLINENAME { get; set; }
    }
}

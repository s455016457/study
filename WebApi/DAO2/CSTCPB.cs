namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSTCPB")]
    public partial class CSTCPB
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

        public decimal? QTY1 { get; set; }

        public decimal? QTY2 { get; set; }

        public decimal? QTY3 { get; set; }

        public decimal? QTY4 { get; set; }

        public decimal? TOTALQTY { get; set; }

        [StringLength(100)]
        public string PROLINE { get; set; }

        public decimal? STDWRK { get; set; }

        public decimal? STDWRKRATE { get; set; }

        public decimal? STDWRK2 { get; set; }

        public decimal? STDWRK2RATE { get; set; }

        public decimal? WORKHOUR { get; set; }

        public decimal? WORKHOUR2 { get; set; }

        public decimal? LABORCOST { get; set; }

        public decimal? FACOVRHAD { get; set; }

        public decimal? FUELCOST { get; set; }

        public decimal? TOTALWRKHR { get; set; }

        public decimal? TOTALWRKHR2 { get; set; }

        public decimal? TOTALLABORCOST { get; set; }

        public decimal? TOTALFACOVRHAD { get; set; }

        public decimal? TOTALFUELCOST { get; set; }

        public int? ISREWORK { get; set; }

        public decimal? STDLABORCOST { get; set; }

        public decimal? STDFACOVRHAD { get; set; }

        public decimal? STDFUELCOST { get; set; }

        public decimal? STDMATCOST { get; set; }

        public decimal? TOTALSTDLABORCOST { get; set; }

        public decimal? TOTALSTDFACOVRHAD { get; set; }

        public decimal? TOTALSTDFUELCOST { get; set; }

        public decimal? TOTALSTDCOST { get; set; }

        public decimal? STDUPRICE { get; set; }

        [StringLength(50)]
        public string PROLINENAME { get; set; }
    }
}

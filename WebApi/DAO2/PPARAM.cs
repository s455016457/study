namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PPARAM")]
    public partial class PPARAM
    {
        public int? ALLOWOUTBOM { get; set; }

        public int? ALLOWNONEWO { get; set; }

        public int? ALLOWOVERMIPLAN { get; set; }

        public int? ALLOWOVERWOPLAN { get; set; }

        public int? ADDSCRAP { get; set; }

        public decimal? OVRATE { get; set; }

        public int? ALLOWNONEMI { get; set; }

        public decimal? WIPOVERIN { get; set; }

        public int? FIRSTLEVEL { get; set; }

        public int? INCLUDEREP { get; set; }

        public int? ALLOWUPDPLANDATE { get; set; }

        public decimal? OVERMIPLANRATE { get; set; }

        public int? EXISTSBOM { get; set; }

        public int? AUTOCLOSE { get; set; }

        public int? REFUNDAFTERCLOSE { get; set; }

        public int? WIPAFTERCLOSE { get; set; }

        public int? ALLOWWIPOVERACT { get; set; }

        public decimal? WIPOVERACTRATE { get; set; }

        public int? REFUNDCHECKRATIO { get; set; }

        public int? PROFLOWCONTROL { get; set; }

        public decimal? PROFLOWCONTROLRATIO { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OWOVERMIPLANBYCUSTOMMI { get; set; }
    }
}

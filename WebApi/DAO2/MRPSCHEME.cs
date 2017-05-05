namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MRPSCHEME")]
    public partial class MRPSCHEME
    {
        [Key]
        [StringLength(30)]
        public string MRPCODE { get; set; }

        [StringLength(100)]
        public string DESCR { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        [StringLength(20)]
        public string ITEMNUM1 { get; set; }

        [StringLength(20)]
        public string ITEMNUM2 { get; set; }

        public int? EXISTSTOCK { get; set; }

        public int? PURCHREQ { get; set; }

        public int? PURCHORDER { get; set; }

        public int? SALESORDER { get; set; }

        public int? WORKORDER { get; set; }

        public int? SAFETYQTY { get; set; }

        [StringLength(20)]
        public string FCTABS { get; set; }

        [StringLength(1)]
        public string SORTBY { get; set; }

        public int? SIMULATION { get; set; }

        public int ISRUNNING { get; set; }

        public DateTime? LASTSTARTDATE { get; set; }

        public DateTime? LASTENDDATE { get; set; }

        public int? SALESFORECAST { get; set; }

        public int? REPMATERIAL { get; set; }
    }
}

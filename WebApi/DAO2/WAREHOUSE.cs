namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WAREHOUSE")]
    public partial class WAREHOUSE
    {
        [Key]
        [StringLength(10)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string DESCR { get; set; }

        [StringLength(50)]
        public string MASTER { get; set; }

        public int? ADDINPR { get; set; }

        public int? ISBACKFLUSH { get; set; }

        public int? ADDINSI { get; set; }

        public int? ISFGWH { get; set; }

        public int? ISFGSCPWH { get; set; }

        public int? ISMATWH { get; set; }

        public int? ISFGWH2 { get; set; }

        public int? ISFGWH3 { get; set; }

        public int? ISMATWH2 { get; set; }

        public int? STOCKOUTREF { get; set; }

        public int? SAFETYSTOCKWARNING { get; set; }

        public bool DISABLED { get; set; }
    }
}

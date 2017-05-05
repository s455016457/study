namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REGHOR")]
    public partial class REGHOR
    {
        [Key]
        [StringLength(20)]
        public string PROLINEID { get; set; }

        public decimal? DAILYHOUR { get; set; }

        public int? WORKONSAT { get; set; }

        public int? WORKONSUN { get; set; }
    }
}

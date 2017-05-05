namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SETPRN")]
    public partial class SETPRN
    {
        [Key]
        [StringLength(100)]
        public string RPTNAME { get; set; }

        [StringLength(200)]
        public string PRINTERNAME { get; set; }

        [StringLength(200)]
        public string PAPERSIZE { get; set; }
    }
}

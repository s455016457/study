namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BEGRECBAL")]
    public partial class BEGRECBAL
    {
        [Key]
        [StringLength(20)]
        public string CUSID { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal INVAMOUNT { get; set; }

        [StringLength(20)]
        public string RECACC { get; set; }

        public DateTime CREATED { get; set; }
    }
}

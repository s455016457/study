namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BEGPAYBAL")]
    public partial class BEGPAYBAL
    {
        [Key]
        [StringLength(20)]
        public string VENID { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal INVAMOUNT { get; set; }

        [StringLength(20)]
        public string PAYACC { get; set; }

        public DateTime CREATED { get; set; }
    }
}

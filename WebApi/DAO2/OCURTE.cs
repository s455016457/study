namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OCURTE")]
    public partial class OCURTE
    {
        [Key]
        [Column(Order = 0, TypeName = "smalldatetime")]
        public DateTime RATEDATE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CURRCODE { get; set; }

        public decimal? RATE { get; set; }

        public virtual OCURRN OCURRN { get; set; }
    }
}

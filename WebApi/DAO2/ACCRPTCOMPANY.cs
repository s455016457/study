namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCRPTCOMPANY")]
    public partial class ACCRPTCOMPANY
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string NAME { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string COMPID { get; set; }
    }
}

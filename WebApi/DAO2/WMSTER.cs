namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMSTER")]
    public partial class WMSTER
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string WAREHOUSE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string MASTERID { get; set; }

        [StringLength(100)]
        public string REMARKS { get; set; }
    }
}

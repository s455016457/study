namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WHQRYA")]
    public partial class WHQRYA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string WAREHOUSE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string USERID { get; set; }

        [StringLength(100)]
        public string REMARKS { get; set; }
    }
}

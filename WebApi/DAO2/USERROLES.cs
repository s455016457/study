namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USERROLES
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string UID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string ROLE { get; set; }
    }
}

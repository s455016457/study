namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_COMPANY
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string COMPID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string COMPNAME { get; set; }
    }
}

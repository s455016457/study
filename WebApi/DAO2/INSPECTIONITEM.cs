namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INSPECTIONITEM")]
    public partial class INSPECTIONITEM
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string WORKPROC { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string INSPITEMID { get; set; }

        [Required]
        [StringLength(200)]
        public string INSPITEMDESCR { get; set; }
    }
}

namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VBSTYP")]
    public partial class VBSTYP
    {
        [Key]
        [StringLength(20)]
        public string VTCODE { get; set; }

        [StringLength(50)]
        public string VTNAME { get; set; }

        [StringLength(500)]
        public string DOCPATH { get; set; }
    }
}

namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OPRJCT")]
    public partial class OPRJCT
    {
        [Key]
        [StringLength(20)]
        public string PRJCODE { get; set; }

        [Required]
        [StringLength(50)]
        public string PRJNAME { get; set; }
    }
}

namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCPROJECT")]
    public partial class ACCPROJECT
    {
        [Key]
        [StringLength(20)]
        public string CODE { get; set; }

        [Required]
        [StringLength(30)]
        public string DESCR { get; set; }
    }
}

namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USRPRF")]
    public partial class USRPRF
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string UID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string KEY { get; set; }

        [Required]
        [StringLength(8000)]
        public string VALUE { get; set; }
    }
}

namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PWKGRP")]
    public partial class PWKGRP
    {
        [Key]
        [StringLength(20)]
        public string CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCR { get; set; }

        [Required]
        [StringLength(2)]
        public string STARTHOUR { get; set; }

        [Required]
        [StringLength(2)]
        public string STARTMINUTE { get; set; }

        [Required]
        [StringLength(2)]
        public string ENDHOUR { get; set; }

        [Required]
        [StringLength(2)]
        public string ENDMINUTE { get; set; }
    }
}

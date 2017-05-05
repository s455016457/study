namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FOMLAA")]
    public partial class FOMLAA
    {
        [StringLength(20)]
        public string ID { get; set; }

        [Required]
        [StringLength(500)]
        public string NAME { get; set; }

        [Required]
        [StringLength(1000)]
        public string DATASRC { get; set; }

        [Required]
        [StringLength(1000)]
        public string FILTERFIELD { get; set; }
    }
}

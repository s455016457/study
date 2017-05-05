namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MRPDOCQUERY")]
    public partial class MRPDOCQUERY
    {
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        [Required]
        [StringLength(500)]
        public string TABLENAME { get; set; }

        [Required]
        [StringLength(1000)]
        public string OUTPUTFIELD { get; set; }

        [Required]
        [StringLength(100)]
        public string FOREIGNKEY { get; set; }

        [Required]
        [StringLength(4000)]
        public string SHOWVIEWJSON { get; set; }

        [Required]
        [StringLength(50)]
        public string QUERYMODULE { get; set; }

        [Required]
        [StringLength(50)]
        public string EXPORTCODE { get; set; }
    }
}

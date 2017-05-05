namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUERYA")]
    public partial class QUERYA
    {
        public long Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Module { get; set; }

        [StringLength(256)]
        public string Entity { get; set; }

        [Required]
        [StringLength(256)]
        public string Property { get; set; }

        [Required]
        [StringLength(256)]
        public string PropertyAlias { get; set; }

        [Required]
        [StringLength(64)]
        public string Type { get; set; }

        public byte Row { get; set; }

        public byte Column { get; set; }

        [StringLength(256)]
        public string DefaultValue { get; set; }

        [StringLength(2000)]
        public string Option { get; set; }

        public int? NotHandle { get; set; }
    }
}

namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("METAAA")]
    public partial class METAAA
    {
        public long ID { get; set; }

        [Required]
        [StringLength(256)]
        public string Entity { get; set; }

        [Required]
        [StringLength(256)]
        public string EntityAlias { get; set; }

        [StringLength(256)]
        public string Table { get; set; }

        [StringLength(256)]
        public string Column { get; set; }

        [Required]
        [StringLength(256)]
        public string Property { get; set; }

        [Required]
        [StringLength(256)]
        public string PropertyAlias { get; set; }

        [Required]
        [StringLength(64)]
        public string Type { get; set; }

        [StringLength(256)]
        public string RefTable { get; set; }

        [StringLength(256)]
        public string RefColumn { get; set; }

        [StringLength(1024)]
        public string ThisColumns { get; set; }

        [StringLength(1024)]
        public string ThatColumns { get; set; }

        public bool? IsPrimaryKey { get; set; }

        public bool? Nullable { get; set; }

        public bool? HasDefault { get; set; }

        [StringLength(256)]
        public string Format { get; set; }

        public int? Display { get; set; }

        public int SEQNUM { get; set; }
    }
}

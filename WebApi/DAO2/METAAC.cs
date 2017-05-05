namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("METAAC")]
    public partial class METAAC
    {
        public long ID { get; set; }

        public int SEQNUM { get; set; }

        [Required]
        [StringLength(256)]
        public string Entity { get; set; }

        [StringLength(256)]
        public string Column { get; set; }

        [Required]
        [StringLength(256)]
        public string Property { get; set; }

        public int Width { get; set; }

        public int? MinWidth { get; set; }

        public int? MaxWidth { get; set; }

        [Required]
        [StringLength(256)]
        public string PropertyAlias { get; set; }

        public int? Display { get; set; }
    }
}

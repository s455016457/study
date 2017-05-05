namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("METAAB")]
    public partial class METAAB
    {
        public long ID { get; set; }

        [Required]
        [StringLength(256)]
        public string Module { get; set; }

        [StringLength(256)]
        public string ModuleAlias { get; set; }

        public byte Level { get; set; }

        [Required]
        [StringLength(256)]
        public string Entity { get; set; }

        [StringLength(256)]
        public string ParentEntity { get; set; }

        [StringLength(1024)]
        public string ThisProperties { get; set; }

        [StringLength(1024)]
        public string ThatProperties { get; set; }

        public int? Display { get; set; }

        public DateTime? LastUpdatedTime { get; set; }
    }
}

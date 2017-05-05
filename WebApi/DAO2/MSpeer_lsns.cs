namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSpeer_lsns
    {
        public int id { get; set; }

        public DateTime? last_updated { get; set; }

        [Required]
        [StringLength(128)]
        public string originator { get; set; }

        [Required]
        [StringLength(128)]
        public string originator_db { get; set; }

        [Required]
        [StringLength(128)]
        public string originator_publication { get; set; }

        public int? originator_publication_id { get; set; }

        public int? originator_db_version { get; set; }

        [MaxLength(16)]
        public byte[] originator_lsn { get; set; }

        public int? originator_version { get; set; }

        public int? originator_id { get; set; }
    }
}

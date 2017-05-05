namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GRAMPA")]
    public partial class GRAMPA
    {
        [Key]
        public int GRAMPA_ID { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(500)]
        public string REMARKS { get; set; }

        public int ENABLED { get; set; }

        [StringLength(5000)]
        public string VIEWJSON { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}

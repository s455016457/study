namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GRADATA")]
    public partial class GRADATA
    {
        [Key]
        public int GRADATA_ID { get; set; }

        [StringLength(50)]
        public string LABELID { get; set; }

        [StringLength(500)]
        public string LABELDESCR { get; set; }

        [StringLength(50)]
        public string ITEMNUM { get; set; }

        public int GRAMPA_ID { get; set; }

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

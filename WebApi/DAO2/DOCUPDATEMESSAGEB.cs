namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOCUPDATEMESSAGEB")]
    public partial class DOCUPDATEMESSAGEB
    {
        [Key]
        public int DOCUPDATEMESSAGEB_ID { get; set; }

        public int DOCUPDATEMESSAGEA_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string DOCNUM { get; set; }

        [StringLength(1000)]
        public string VALUE { get; set; }

        [Required]
        [StringLength(1000)]
        public string REMARKS { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }
    }
}

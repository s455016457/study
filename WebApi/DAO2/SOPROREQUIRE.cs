namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SOPROREQUIRE")]
    public partial class SOPROREQUIRE
    {
        [Key]
        public int SOPROREQUIRE_ID { get; set; }

        [StringLength(100)]
        public string NAME { get; set; }

        public int GRAMPA_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string SONUM { get; set; }

        [Required]
        [StringLength(50)]
        public string ITEMNUM { get; set; }

        [StringLength(5000)]
        public string VIEWJSON { get; set; }

        [Required]
        [StringLength(20)]
        public string LOT { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}

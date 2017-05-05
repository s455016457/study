namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GRADVA")]
    public partial class GRADVA
    {
        [Key]
        public int GRADVA_ID { get; set; }

        public int GRADATA_ID { get; set; }

        public int GRAMPB_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string VALUE { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}

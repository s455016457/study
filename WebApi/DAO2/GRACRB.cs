namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GRACRB")]
    public partial class GRACRB
    {
        [Key]
        public int GRACRB_ID { get; set; }

        public int GRACRA_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        [Required]
        [StringLength(5)]
        public string RANKTYPE { get; set; }

        [StringLength(1)]
        public string COLOR { get; set; }

        [StringLength(1)]
        public string LABELNAMESEPARATOR_C { get; set; }

        public int COSEQNUM { get; set; }

        [Required]
        [StringLength(500)]
        public string REMARK { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }

        [StringLength(20)]
        public string NAMECOMBINATIONMETHOD { get; set; }

        [StringLength(20)]
        public string LABELIDCOMBINATIONMETHOD { get; set; }
    }
}

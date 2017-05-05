namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USEROP")]
    public partial class USEROP
    {
        [Key]
        public int SEQNUM { get; set; }

        [Required]
        [StringLength(20)]
        public string UID { get; set; }

        public DateTime OPDATE { get; set; }

        [Required]
        [StringLength(80)]
        public string MID { get; set; }

        [Required]
        [StringLength(500)]
        public string OPACTION { get; set; }
    }
}

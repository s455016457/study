namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MNUCTG")]
    public partial class MNUCTG
    {
        [Key]
        [Column("MNUCTG")]
        [StringLength(50)]
        public string MNUCTG1 { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string ORD { get; set; }
    }
}

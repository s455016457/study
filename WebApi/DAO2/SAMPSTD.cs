namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAMPSTD")]
    public partial class SAMPSTD
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODE { get; set; }

        [Required]
        [StringLength(255)]
        public string DESCR { get; set; }

        [Required]
        [StringLength(20)]
        public string SAMPLEMETHOD { get; set; }

        [Required]
        [StringLength(10)]
        public string QCLEVEL { get; set; }

        [Required]
        [StringLength(10)]
        public string YGD { get; set; }

        [Required]
        [StringLength(10)]
        public string AQL { get; set; }
    }
}

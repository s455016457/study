namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ECITYA")]
    public partial class ECITYA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string PROVINCE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CITY { get; set; }

        [Required]
        [StringLength(50)]
        public string ASSISTANT { get; set; }

        public int SORTORDER { get; set; }
    }
}

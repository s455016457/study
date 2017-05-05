namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EPROVI")]
    public partial class EPROVI
    {
        [Key]
        [StringLength(50)]
        public string PROVINCE { get; set; }

        [Required]
        [StringLength(50)]
        public string ASSISTANT { get; set; }

        public int SORTORDER { get; set; }
    }
}

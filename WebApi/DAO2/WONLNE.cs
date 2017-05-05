namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WONLNE")]
    public partial class WONLNE
    {
        [Key]
        [StringLength(30)]
        public string UID { get; set; }

        [Required]
        [StringLength(50)]
        public string MID { get; set; }

        public DateTime LASTDATETIME { get; set; }
    }
}

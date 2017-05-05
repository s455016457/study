namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYLOCK")]
    public partial class SYLOCK
    {
        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [StringLength(20)]
        public string UID { get; set; }

        public int LOCKMINUTE { get; set; }

        public DateTime? LASTDATETIME { get; set; }
    }
}

namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SOACYA")]
    public partial class SOACYA
    {
        [Key]
        [StringLength(30)]
        public string SONUM { get; set; }

        [StringLength(1)]
        public string WFSTATUS { get; set; }

        [StringLength(1)]
        public string ISPRINTED { get; set; }

        [StringLength(50)]
        public string OBJTYPE { get; set; }

        public bool CLOSED { get; set; }

        public DateTime? CLOSEDSTAMP { get; set; }
    }
}

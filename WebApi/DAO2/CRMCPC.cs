namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRMCPC")]
    public partial class CRMCPC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CPTNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CUSNUM { get; set; }

        [StringLength(50)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        [StringLength(50)]
        public string UPDATEDBY { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}

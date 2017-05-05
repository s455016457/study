namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MAGENT")]
    public partial class MAGENT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string UID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MID { get; set; }

        [StringLength(50)]
        public string AGENTID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EFFDATE { get; set; }
    }
}

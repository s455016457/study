namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("URPTAE")]
    public partial class URPTAE
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RPTID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string USERID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PARAMID { get; set; }

        [StringLength(100)]
        public string LASTVALUE { get; set; }
    }
}

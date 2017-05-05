namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MODULEACTION")]
    public partial class MODULEACTION
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AID { get; set; }

        public int VALUE { get; set; }

        [StringLength(50)]
        public string DESCR { get; set; }
    }
}

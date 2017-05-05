namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EXPCOT")]
    public partial class EXPCOT
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FPERIOD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string PROLINE { get; set; }

        public decimal COST1 { get; set; }

        public decimal COST2 { get; set; }

        public decimal COST3 { get; set; }
    }
}

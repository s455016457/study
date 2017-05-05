namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ROLEACTION")]
    public partial class ROLEACTION
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string UID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AID { get; set; }
    }
}

namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MODULES
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MNUCTG { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CATEGORY { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string MID { get; set; }

        [Required]
        [StringLength(30)]
        public string NAME { get; set; }

        [StringLength(50)]
        public string IMAGE { get; set; }

        [StringLength(50)]
        public string DESCR { get; set; }

        [StringLength(50)]
        public string URL { get; set; }

        public int? ORD { get; set; }

        [StringLength(50)]
        public string ADDED { get; set; }
    }
}

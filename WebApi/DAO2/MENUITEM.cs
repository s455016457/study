namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MENUITEM")]
    public partial class MENUITEM
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MNUCTG { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(10)]
        public string ORD { get; set; }
    }
}

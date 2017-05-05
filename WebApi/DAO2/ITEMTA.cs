namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ITEMTA")]
    public partial class ITEMTA
    {
        [Key]
        [StringLength(2)]
        public string ITEMTYPEATTID { get; set; }

        [Required]
        [StringLength(50)]
        public string ITEMTYPEATTNAME { get; set; }

        public int ISSYSTEM { get; set; }

        public int ORD { get; set; }
    }
}

namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EFILEB")]
    public partial class EFILEB
    {
        [Key]
        [StringLength(50)]
        public string TYPEID { get; set; }

        [Required]
        [StringLength(50)]
        public string MID { get; set; }

        [Required]
        [StringLength(100)]
        public string NAME { get; set; }

        public int CANVIEW { get; set; }

        public int CANVIEWALL { get; set; }

        public int CANUPLOAD { get; set; }

        public int CANDELETE { get; set; }
    }
}

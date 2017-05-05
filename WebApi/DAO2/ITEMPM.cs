namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ITEMPM")]
    public partial class ITEMPM
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string TYPECODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PARAMCODE { get; set; }

        [Required]
        [StringLength(100)]
        public string PARAMDESCR { get; set; }

        public int PARAMORD { get; set; }

        public int ALLOWNULL { get; set; }
    }
}

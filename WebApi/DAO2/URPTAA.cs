namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("URPTAA")]
    public partial class URPTAA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TYPEID { get; set; }

        [Required]
        [StringLength(100)]
        public string TYPENAME { get; set; }
    }
}

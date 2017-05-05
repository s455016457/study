namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("URPTAB")]
    public partial class URPTAB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RPTID { get; set; }

        [Required]
        [StringLength(100)]
        public string RPTNAME { get; set; }

        public int TYPEID { get; set; }

        [Required]
        [StringLength(100)]
        public string DICTID { get; set; }

        public int URIGHT { get; set; }

        public int ISALLOWED { get; set; }
    }
}

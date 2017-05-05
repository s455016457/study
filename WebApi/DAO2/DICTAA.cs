namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DICTAA")]
    public partial class DICTAA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DICTID { get; set; }

        [Required]
        [StringLength(200)]
        public string DICTNAME { get; set; }

        [Required]
        [StringLength(2000)]
        public string DICTTABLE { get; set; }
    }
}

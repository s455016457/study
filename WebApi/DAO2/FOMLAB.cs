namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FOMLAB")]
    public partial class FOMLAB
    {
        public int ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string TYPEID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string NAME { get; set; }

        [StringLength(1000)]
        public string DESCR { get; set; }

        [StringLength(1000)]
        public string DATASRC { get; set; }

        [Required]
        [StringLength(1000)]
        public string SELECTFIELD { get; set; }

        [StringLength(1000)]
        public string FILTERFIELD { get; set; }

        [StringLength(1000)]
        public string INPUTFIELD { get; set; }
    }
}

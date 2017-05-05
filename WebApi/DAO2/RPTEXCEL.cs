namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RPTEXCEL")]
    public partial class RPTEXCEL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string PRONAME { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string FIELDNAME { get; set; }

        [Required]
        [StringLength(100)]
        public string CHNAME { get; set; }

        [StringLength(100)]
        public string ENGNAME { get; set; }

        [StringLength(200)]
        public string STYLE { get; set; }

        public int SEQNUM { get; set; }

        [StringLength(20)]
        public string TYPE { get; set; }
    }
}

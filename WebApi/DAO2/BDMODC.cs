namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BDMODC")]
    public partial class BDMODC
    {
        [Key]
        public int BDMODC_ID { get; set; }

        public int BDMODA_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string FIELDNAME { get; set; }

        [Required]
        [StringLength(100)]
        public string SHOWFIELDNAME { get; set; }

        [Required]
        [StringLength(100)]
        public string FIELDTYPE { get; set; }

        [Required]
        [StringLength(100)]
        public string SHOWTYPE { get; set; }

        [StringLength(500)]
        public string DATASRC { get; set; }

        [StringLength(1000)]
        public string BEFOREUPDATE { get; set; }

        [StringLength(1000)]
        public string AFTERUPDATE { get; set; }

        public int ORD { get; set; }
    }
}

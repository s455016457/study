namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOCUPDATEMESSAGEA")]
    public partial class DOCUPDATEMESSAGEA
    {
        [Key]
        public int DOCUPDATEMESSAGEA_ID { get; set; }

        [StringLength(50)]
        public string MID { get; set; }

        [StringLength(50)]
        public string TABLENAME { get; set; }

        [StringLength(50)]
        public string TABLESHOWNAME { get; set; }

        [Required]
        [StringLength(100)]
        public string FIELDNAME { get; set; }

        [Required]
        [StringLength(100)]
        public string FIELDSHOWNAME { get; set; }
    }
}

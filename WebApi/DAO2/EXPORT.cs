namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EXPORT")]
    public partial class EXPORT
    {
        public long ID { get; set; }

        [Required]
        [StringLength(50)]
        public string CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string FIELD { get; set; }

        [Required]
        [StringLength(50)]
        public string DATATYPE { get; set; }

        [StringLength(200)]
        public string FIELDNAME { get; set; }

        [StringLength(1000)]
        public string DEFAULTVALUE { get; set; }

        [StringLength(50)]
        public string FORMAT { get; set; }

        public int ORDER { get; set; }

        [StringLength(200)]
        public string GROUP1 { get; set; }

        public int? GROUP1ORD { get; set; }

        [StringLength(200)]
        public string GROUP2 { get; set; }

        public int? GROUP2ORD { get; set; }
    }
}

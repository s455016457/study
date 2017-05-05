namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BDMODA")]
    public partial class BDMODA
    {
        [Key]
        public int BDMODA_ID { get; set; }

        [StringLength(50)]
        public string MID { get; set; }

        [StringLength(50)]
        public string TABLENAME { get; set; }

        [StringLength(50)]
        public string SHOWNAME { get; set; }
    }
}

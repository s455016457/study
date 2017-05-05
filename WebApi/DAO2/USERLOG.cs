namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USERLOG")]
    public partial class USERLOG
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string UID { get; set; }

        [Required]
        [StringLength(20)]
        public string IP { get; set; }

        [Required]
        [StringLength(20)]
        public string LOGDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string LOGTIME { get; set; }

        [StringLength(50)]
        public string MID { get; set; }

        public DateTime? CREATED { get; set; }
    }
}

namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SALESPERSON")]
    public partial class SALESPERSON
    {
        [Key]
        [StringLength(20)]
        public string CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCR { get; set; }

        [StringLength(50)]
        public string UID { get; set; }

        public int ISDENY { get; set; }

        [StringLength(50)]
        public string TEL { get; set; }

        [StringLength(50)]
        public string FAX { get; set; }

        [StringLength(20)]
        public string SALESREGION { get; set; }

        [StringLength(30)]
        public string SUPERVISOR { get; set; }

        [StringLength(100)]
        public string DESCRENG { get; set; }
    }
}

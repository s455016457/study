namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QCITEM")]
    public partial class QCITEM
    {
        [Key]
        [StringLength(20)]
        public string CODE { get; set; }

        [StringLength(100)]
        public string DESCR { get; set; }

        [StringLength(20)]
        public string ANALYMETHOD { get; set; }

        [StringLength(20)]
        public string INSPBASIS { get; set; }

        [StringLength(20)]
        public string QCMETHOD { get; set; }

        [StringLength(20)]
        public string INSPTOOL { get; set; }

        [StringLength(20)]
        public string SAMPSTD { get; set; }

        [StringLength(20)]
        public string UOM { get; set; }

        public int? CRITICALCHK { get; set; }

        [StringLength(20)]
        public string DEFECTGRADE { get; set; }

        [StringLength(20)]
        public string QCSCHMID { get; set; }
    }
}

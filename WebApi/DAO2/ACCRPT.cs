namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCRPT")]
    public partial class ACCRPT
    {
        [Key]
        [StringLength(20)]
        public string NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string TITLE { get; set; }

        public int RPTTYPE { get; set; }

        public int LVL { get; set; }

        public int ORD { get; set; }

        public int COUNTER { get; set; }

        public int SROW { get; set; }

        public int SCOL { get; set; }

        public int PERIODFROM { get; set; }

        public int PERIODTO { get; set; }

        public int USEDOCDATE { get; set; }

        public int USEOBAL { get; set; }

        public int SHOWNOENTRY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATEFROM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATETO { get; set; }

        [Required]
        [StringLength(20)]
        public string JOUFROM { get; set; }

        [Required]
        [StringLength(20)]
        public string JOUTO { get; set; }
    }
}

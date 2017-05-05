namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("URPTAC")]
    public partial class URPTAC
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RPTID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PARAMID { get; set; }

        [StringLength(50)]
        public string LEFTSYMBOL { get; set; }

        public int DICTFIELD { get; set; }

        [StringLength(50)]
        public string FIELDEXP { get; set; }

        [StringLength(100)]
        public string DEFAULTVALUE { get; set; }

        [StringLength(50)]
        public string EXPCON { get; set; }

        [StringLength(50)]
        public string RIGHTSYMBOL { get; set; }

        public int? ISREADONLY { get; set; }
    }
}

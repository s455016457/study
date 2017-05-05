namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FLWDAT")]
    public partial class FLWDAT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FDID { get; set; }

        public int? WFID { get; set; }

        [StringLength(50)]
        public string USRID { get; set; }

        [StringLength(50)]
        public string DOCENTRY { get; set; }

        [StringLength(100)]
        public string OBJTYPE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DOCDATE { get; set; }

        public int? CURRSTEP { get; set; }

        [StringLength(1)]
        public string FSTATUS { get; set; }

        [StringLength(100)]
        public string REMARKS { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(1)]
        public string ISDRAFT { get; set; }
    }
}

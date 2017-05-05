namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FPERIOD")]
    public partial class FPERIOD
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime BEGDATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ENDDATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime F_DUEDATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime T_DUEDATE { get; set; }

        public int ACTIVED { get; set; }

        public int LOCKED { get; set; }

        public int SUBYEAR { get; set; }

        public int SUBMONTH { get; set; }

        public int PERIODNUM { get; set; }
    }
}

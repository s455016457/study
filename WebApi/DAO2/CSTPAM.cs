namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSTPAM")]
    public partial class CSTPAM
    {
        [Key]
        [Column("CSTPAM")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CSTPAM1 { get; set; }

        public int? CALCBTNDISPLAY { get; set; }

        [StringLength(2000)]
        public string MATERIALITEMGRP { get; set; }

        [StringLength(2000)]
        public string PRODUCTITEMGRP { get; set; }

        [StringLength(2000)]
        public string FIXEDASSETSITEMGRP { get; set; }

        public int? INITPERIOD { get; set; }
    }
}

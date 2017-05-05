namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syncobj_0x3737364133353237
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string CODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string DESCR { get; set; }

        [StringLength(10)]
        public string PARENTID { get; set; }

        public int? MINLEN { get; set; }

        public int? MAXLEN { get; set; }

        [StringLength(2)]
        public string ATTRIBTYPE { get; set; }

        [StringLength(30)]
        public string INVACC { get; set; }

        public decimal? OVERQTY { get; set; }

        public int? ISFGREF { get; set; }

        [StringLength(10)]
        public string ITEMGRP { get; set; }

        public int? ISVIRTUAL { get; set; }

        public int? LOTMANAGED { get; set; }

        public decimal? OVERRATE { get; set; }

        [StringLength(20)]
        public string PREFIX { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal MINSCPRATE { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal MAXSCPRATE { get; set; }
    }
}

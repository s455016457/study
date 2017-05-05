namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_PAYEE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string TYPE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string CODE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string NAME { get; set; }

        [StringLength(200)]
        public string NAME2 { get; set; }

        [StringLength(20)]
        public string PAYTERM { get; set; }

        [StringLength(20)]
        public string PAYMETHOD { get; set; }

        [StringLength(20)]
        public string TRADETERM { get; set; }

        [StringLength(20)]
        public string CURR { get; set; }

        [StringLength(20)]
        public string REGION { get; set; }
    }
}

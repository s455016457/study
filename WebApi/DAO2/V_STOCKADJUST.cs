namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_STOCKADJUST
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string SANUM { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "smalldatetime")]
        public DateTime SADATE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string LOCID { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string WAREHOUSEDESCR { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COMPLETED { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime CREATED { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? UPDATESTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEUSER { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal CURRQTY { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal ADJQTY { get; set; }

        [StringLength(6)]
        public string COMPLETEDESCR { get; set; }
    }
}

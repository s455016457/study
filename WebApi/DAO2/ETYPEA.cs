namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ETYPEA")]
    public partial class ETYPEA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MODULE { get; set; }

        [StringLength(500)]
        public string MODULENAME { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string GROUPID { get; set; }

        [StringLength(100)]
        public string GROUPNAME { get; set; }

        [StringLength(500)]
        public string DESCR { get; set; }

        public byte? CANMODIFY { get; set; }

        public byte? ISUSERDEF { get; set; }

        public int? CODELENGTH { get; set; }

        public int? NAMELENGTH { get; set; }

        public int? ORDID { get; set; }

        [StringLength(50)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        [StringLength(50)]
        public string UPDATEDBY { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}

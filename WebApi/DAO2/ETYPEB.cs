namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ETYPEB")]
    public partial class ETYPEB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MODULE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string GROUPID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string TYPECODE { get; set; }

        [StringLength(100)]
        public string TYPENAME { get; set; }

        [StringLength(100)]
        public string DEFAULTNAME { get; set; }

        [StringLength(500)]
        public string DESCR { get; set; }

        public byte? ISSYSTEM { get; set; }

        public byte? ISMIX { get; set; }

        public int? ORDID { get; set; }

        [StringLength(50)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        [StringLength(50)]
        public string UPDATEDBY { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}

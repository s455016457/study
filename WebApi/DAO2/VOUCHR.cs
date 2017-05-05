namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VOUCHR")]
    public partial class VOUCHR
    {
        [Key]
        [StringLength(20)]
        public string VID { get; set; }

        [Required]
        [StringLength(2)]
        public string VTYPE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime VDATE { get; set; }

        public int FYEAR { get; set; }

        public int FPERIOD { get; set; }

        public int VNUM { get; set; }

        [StringLength(500)]
        public string VREFINFO { get; set; }

        [Required]
        [StringLength(20)]
        public string VBASETYPE { get; set; }

        [Required]
        [StringLength(20)]
        public string VBASENUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? VBASEDATE { get; set; }

        public int? ATTACHS { get; set; }

        [StringLength(20)]
        public string PRJCODE { get; set; }

        [StringLength(20)]
        public string DEPTID { get; set; }

        [StringLength(20)]
        public string PAYEE { get; set; }

        [StringLength(1)]
        public string PAYEETYPE { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(20)]
        public string APPROVEDBY { get; set; }

        public DateTime? APPROVED { get; set; }
    }
}

namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRMCSE")]
    public partial class CRMCSE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CSNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SEQNUM { get; set; }

        [StringLength(50)]
        public string SATISFACTION { get; set; }

        [StringLength(200)]
        public string RETUSERID { get; set; }

        public DateTime? RETIDATE { get; set; }

        [StringLength(500)]
        public string RETRESULT { get; set; }

        [StringLength(20)]
        public string DEPTID { get; set; }

        [StringLength(50)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        [StringLength(50)]
        public string UPDATEDBY { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}

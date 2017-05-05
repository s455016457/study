namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SYSPARAMETER")]
    public partial class SYSPARAMETER
    {
        [Key]
        [StringLength(50)]
        public string PARID { get; set; }

        [Required]
        [StringLength(500)]
        public string NAME { get; set; }

        public bool ENABLED { get; set; }

        public bool HASVALUE { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string PARGROUP { get; set; }

        [StringLength(50)]
        public string PARTYPE { get; set; }

        public int IDORD { get; set; }

        public int GRPORD { get; set; }

        public int TYPORD { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}

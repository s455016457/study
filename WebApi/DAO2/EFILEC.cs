namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EFILEC")]
    public partial class EFILEC
    {
        [Key]
        public long FOLDERID { get; set; }

        [Required]
        [StringLength(200)]
        public string FOLDERNAME { get; set; }

        public long PARENTID { get; set; }

        public bool? ISSHARE { get; set; }

        [StringLength(50)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        [StringLength(50)]
        public string UPDATEDBY { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}

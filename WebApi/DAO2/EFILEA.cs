namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EFILEA")]
    public partial class EFILEA
    {
        public long ID { get; set; }

        public long? FOLDERID { get; set; }

        [StringLength(50)]
        public string TYPEID { get; set; }

        [StringLength(100)]
        public string REFKEY { get; set; }

        [Required]
        [StringLength(200)]
        public string FILENAME { get; set; }

        [StringLength(20)]
        public string EXTENSION { get; set; }

        public long FILELENGTH { get; set; }

        [StringLength(100)]
        public string CONTENTTYPE { get; set; }

        [Required]
        [StringLength(500)]
        public string FILEPATH { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

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

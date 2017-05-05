namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CALDAR")]
    public partial class CALDAR
    {
        public long ID { get; set; }

        public int TYPE { get; set; }

        [Required]
        [StringLength(200)]
        public string TITLE { get; set; }

        [StringLength(2000)]
        public string CONTENT { get; set; }

        public DateTime STARTTIME { get; set; }

        public DateTime? ENDTIME { get; set; }

        public bool? ALLDAY { get; set; }

        [StringLength(500)]
        public string LOCATION { get; set; }

        public int? REMINDER { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [Required]
        [StringLength(50)]
        public string CREATEDBY { get; set; }

        public DateTime CREATEDSTAMP { get; set; }

        [StringLength(50)]
        public string UPDATEDBY { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}

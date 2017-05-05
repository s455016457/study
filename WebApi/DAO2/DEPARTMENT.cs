namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEPARTMENT")]
    public partial class DEPARTMENT
    {
        [Key]
        [StringLength(20)]
        public string DEPTID { get; set; }

        [Required]
        [StringLength(100)]
        public string DEPTNAME { get; set; }

        public DateTime CREATED { get; set; }

        [Required]
        [StringLength(10)]
        public string CREATEDBY { get; set; }

        public DateTime? UPDATESTAMP { get; set; }

        [StringLength(10)]
        public string UPDATEUSER { get; set; }

        [StringLength(20)]
        public string PARENTID { get; set; }
    }
}

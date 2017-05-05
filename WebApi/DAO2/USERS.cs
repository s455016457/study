namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USERS
    {
        [Key]
        [StringLength(20)]
        public string UID { get; set; }

        [Required]
        [StringLength(100)]
        public string NAME { get; set; }

        [StringLength(20)]
        public string PWD { get; set; }

        [StringLength(10)]
        public string DEPT { get; set; }

        [StringLength(100)]
        public string DESCR { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        public short ISROLE { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? UPDATESTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEUSER { get; set; }

        public short STATUS { get; set; }

        public int? CHANGEDPWD { get; set; }

        public int? INTERNETACCESS { get; set; }
    }
}

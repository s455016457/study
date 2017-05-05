namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APPLOG")]
    public partial class APPLOG
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string APPKEY { get; set; }

        [StringLength(256)]
        public string IP { get; set; }

        [StringLength(256)]
        public string METHOD { get; set; }

        public bool? SUCCESS { get; set; }

        [StringLength(4000)]
        public string REMARK { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }
    }
}

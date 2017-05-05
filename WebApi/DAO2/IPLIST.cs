namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IPLIST")]
    public partial class IPLIST
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string IPTYPE { get; set; }

        [StringLength(30)]
        public string IP1 { get; set; }

        [StringLength(30)]
        public string IP2 { get; set; }
    }
}

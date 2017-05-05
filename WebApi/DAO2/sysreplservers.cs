namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysreplservers
    {
        [Key]
        public string srvname { get; set; }

        public int? srvid { get; set; }
    }
}

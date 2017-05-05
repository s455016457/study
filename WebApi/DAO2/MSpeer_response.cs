namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSpeer_response
    {
        public int? request_id { get; set; }

        [Key]
        [Column(Order = 0)]
        public string peer { get; set; }

        [Key]
        [Column(Order = 1)]
        public string peer_db { get; set; }

        public DateTime? received_date { get; set; }
    }
}

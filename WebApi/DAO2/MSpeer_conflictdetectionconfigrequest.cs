namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSpeer_conflictdetectionconfigrequest
    {
        public int id { get; set; }

        [Required]
        [StringLength(128)]
        public string publication { get; set; }

        public DateTime sent_date { get; set; }

        public int timeout { get; set; }

        public DateTime modified_date { get; set; }

        [Required]
        [StringLength(32)]
        public string progress_phase { get; set; }

        public bool phase_timed_out { get; set; }
    }
}

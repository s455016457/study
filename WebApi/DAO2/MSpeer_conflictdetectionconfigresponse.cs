namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSpeer_conflictdetectionconfigresponse
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int request_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public string peer_node { get; set; }

        [Key]
        [Column(Order = 2)]
        public string peer_db { get; set; }

        public int? peer_version { get; set; }

        public int? peer_db_version { get; set; }

        public bool? is_peer { get; set; }

        public bool? conflictdetection_enabled { get; set; }

        public int? originator_id { get; set; }

        public int? peer_conflict_retention { get; set; }

        public bool? peer_continue_onconflict { get; set; }

        [Column(TypeName = "xml")]
        public string peer_subscriptions { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(32)]
        public string progress_phase { get; set; }

        public DateTime? modified_date { get; set; }
    }
}

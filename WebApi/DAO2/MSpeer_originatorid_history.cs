namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSpeer_originatorid_history
    {
        [Key]
        [Column(Order = 0)]
        public string originator_publication { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int originator_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public string originator_node { get; set; }

        [Key]
        [Column(Order = 3)]
        public string originator_db { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int originator_db_version { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int originator_version { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime inserted_date { get; set; }
    }
}

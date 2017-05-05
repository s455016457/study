namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syssubscriptions
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int artid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short srvid { get; set; }

        [Key]
        [Column(Order = 2)]
        public string dest_db { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte status { get; set; }

        [Key]
        [Column(Order = 4)]
        public byte sync_type { get; set; }

        [Key]
        [Column(Order = 5)]
        public string login_name { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int subscription_type { get; set; }

        [MaxLength(16)]
        public byte[] distribution_jobid { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] timestamp { get; set; }

        [Key]
        [Column(Order = 8)]
        public byte update_mode { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool loopback_detection { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool queued_reinit { get; set; }

        [Key]
        [Column(Order = 11)]
        public byte nosync_type { get; set; }

        [Key]
        [Column(Order = 12)]
        public string srvname { get; set; }
    }
}

namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syspublications
    {
        [StringLength(255)]
        public string description { get; set; }

        [Key]
        [Column(Order = 0)]
        public string name { get; set; }

        [Key]
        [Column(Order = 1)]
        public int pubid { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte repl_freq { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte status { get; set; }

        [Key]
        [Column(Order = 4)]
        public byte sync_method { get; set; }

        [MaxLength(16)]
        public byte[] snapshot_jobid { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool independent_agent { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool immediate_sync { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool enabled_for_internet { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool allow_push { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool allow_pull { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool allow_anonymous { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool immediate_sync_ready { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool allow_sync_tran { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool autogen_sync_procs { get; set; }

        public int? retention { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool allow_queued_tran { get; set; }

        [Key]
        [Column(Order = 15)]
        public bool snapshot_in_defaultfolder { get; set; }

        [StringLength(255)]
        public string alt_snapshot_folder { get; set; }

        [StringLength(255)]
        public string pre_snapshot_script { get; set; }

        [StringLength(255)]
        public string post_snapshot_script { get; set; }

        [Key]
        [Column(Order = 16)]
        public bool compress_snapshot { get; set; }

        [StringLength(128)]
        public string ftp_address { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ftp_port { get; set; }

        [StringLength(255)]
        public string ftp_subdirectory { get; set; }

        [StringLength(128)]
        public string ftp_login { get; set; }

        [StringLength(524)]
        public string ftp_password { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool allow_dts { get; set; }

        [Key]
        [Column(Order = 19)]
        public bool allow_subscription_copy { get; set; }

        public bool? centralized_conflicts { get; set; }

        public int? conflict_retention { get; set; }

        public int? conflict_policy { get; set; }

        public int? queue_type { get; set; }

        [StringLength(128)]
        public string ad_guidname { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int backward_comp_level { get; set; }

        [Key]
        [Column(Order = 21)]
        public bool allow_initialize_from_backup { get; set; }

        [MaxLength(10)]
        public byte[] min_autonosync_lsn { get; set; }

        public int? replicate_ddl { get; set; }

        [Key]
        [Column(Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int options { get; set; }

        public int? originator_id { get; set; }
    }
}

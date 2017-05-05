namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysarticles
    {
        [Key]
        [Column(Order = 0)]
        public int artid { get; set; }

        [StringLength(255)]
        public string creation_script { get; set; }

        [StringLength(255)]
        public string del_cmd { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [Key]
        [Column(Order = 1)]
        public string dest_table { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int filter { get; set; }

        [Column(TypeName = "ntext")]
        public string filter_clause { get; set; }

        [StringLength(255)]
        public string ins_cmd { get; set; }

        [Key]
        [Column(Order = 3)]
        public string name { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int objid { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pubid { get; set; }

        [Key]
        [Column(Order = 6)]
        public byte pre_creation_cmd { get; set; }

        [Key]
        [Column(Order = 7)]
        public byte status { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sync_objid { get; set; }

        [Key]
        [Column(Order = 9)]
        public byte type { get; set; }

        [StringLength(255)]
        public string upd_cmd { get; set; }

        [MaxLength(8)]
        public byte[] schema_option { get; set; }

        [StringLength(128)]
        public string dest_owner { get; set; }

        public int? ins_scripting_proc { get; set; }

        public int? del_scripting_proc { get; set; }

        public int? upd_scripting_proc { get; set; }

        [StringLength(2048)]
        public string custom_script { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool fire_triggers_on_snapshot { get; set; }
    }
}

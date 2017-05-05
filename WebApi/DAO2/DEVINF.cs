namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEVINF")]
    public partial class DEVINF
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string ESN { get; set; }

        [StringLength(100)]
        public string IMEI { get; set; }

        [StringLength(100)]
        public string MEID { get; set; }

        [StringLength(100)]
        public string BRAND { get; set; }

        [StringLength(100)]
        public string MODELID { get; set; }

        [StringLength(100)]
        public string STORAGE { get; set; }

        [StringLength(100)]
        public string COLOR { get; set; }

        [StringLength(100)]
        public string LOTNUM { get; set; }

        [StringLength(100)]
        public string VENNAME { get; set; }

        [StringLength(100)]
        public string DEPTID { get; set; }

        public bool? ISREFUND { get; set; }

        [StringLength(100)]
        public string PROGRESS { get; set; }

        public string REQUESTPARAM { get; set; }

        public string REQUESTCOOKIE { get; set; }

        public string RESPONDRAW { get; set; }

        public int? ISVERIFIED { get; set; }

        public DateTime? VERIFIEDSTAMP { get; set; }

        public int? SUCCESS { get; set; }

        public string ERRORMESSAGE { get; set; }

        public string HTMLSTRING { get; set; }

        [StringLength(1000)]
        public string DEVICENAME { get; set; }

        [StringLength(20)]
        public string CREATEDUSER { get; set; }

        public DateTime? CREATEDSTAMP { get; set; }

        [StringLength(20)]
        public string UPDATEDUSER { get; set; }

        public DateTime? UPDATEDSTAMP { get; set; }
    }
}

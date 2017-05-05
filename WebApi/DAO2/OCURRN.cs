namespace DAO2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OCURRN")]
    public partial class OCURRN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OCURRN()
        {
            OCURTE = new HashSet<OCURTE>();
        }

        [Key]
        [StringLength(10)]
        public string CURRCODE { get; set; }

        [StringLength(20)]
        public string CURRNAME { get; set; }

        [StringLength(20)]
        public string CHKNAME { get; set; }

        [StringLength(20)]
        public string CHK100NAME { get; set; }

        [StringLength(20)]
        public string FRGNNAME { get; set; }

        [StringLength(20)]
        public string F100NAME { get; set; }

        public int? DECIMALS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OCURTE> OCURTE { get; set; }
    }
}

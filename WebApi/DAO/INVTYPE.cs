//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class INVTYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INVTYPE()
        {
            this.POes = new HashSet<PO>();
            this.VENDORs = new HashSet<VENDOR>();
        }
    
        public string CODE { get; set; }
        public string DESCR { get; set; }
        public decimal TAXRATE { get; set; }
        public string INPUTVAT { get; set; }
        public string OUTPUTVAT { get; set; }
        public Nullable<int> ISCALTAX { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PO> POes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDOR> VENDORs { get; set; }
    }
}

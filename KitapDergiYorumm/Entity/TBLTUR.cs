//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KitapDergiYorumm.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLTUR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLTUR()
        {
            this.TBLBLOG = new HashSet<TBLBLOG>();
        }
    
        public byte TURID { get; set; }
        public string TURAD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLBLOG> TBLBLOG { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AracSatis.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Musteri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Musteri()
        {
            this.Tbl_Satis = new HashSet<Tbl_Satis>();
        }
    
        public int MusteriID { get; set; }
        public string MusteriAD { get; set; }
        public string MusteriSOYAD { get; set; }
        public string MusteriTEL { get; set; }
        public string MusteriADRES { get; set; }
        public string MusteriMAIL { get; set; }
        public string MusteriSIFRE { get; set; }
        public Nullable<int> MusteriBAKIYE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Satis> Tbl_Satis { get; set; }
    }
}

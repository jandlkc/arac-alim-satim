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
    
    public partial class Tbl_Satis
    {
        public byte SatisID { get; set; }
        public Nullable<int> Musteri { get; set; }
        public Nullable<int> Arac { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    
        public virtual Tbl_Arac Tbl_Arac { get; set; }
        public virtual Tbl_Musteri Tbl_Musteri { get; set; }
    }
}

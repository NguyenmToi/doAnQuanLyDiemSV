//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class LOAITAIKHOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAITAIKHOAN()
        {
            this.TAIKHOANGVs = new HashSet<TAIKHOANGV>();
        }
    
        public int MALOAITAIKHOAN { get; set; }
        public string TENLOAITAIKHOAN { get; set; }
        public string GHICHU { get; set; }
        public bool TRANGTHAI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAIKHOANGV> TAIKHOANGVs { get; set; }
    }
}

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
    
    public partial class SINHVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SINHVIEN()
        {
            this.DIEMs = new HashSet<DIEM>();
            this.DIEMTK_SV = new HashSet<DIEMTK_SV>();
        }
    
        public string MSSV { get; set; }
        public string HOTEN { get; set; }
        public Nullable<bool> GIOITINH { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public string MALOP { get; set; }
        public string CCCD { get; set; }
        public string DANTOC { get; set; }
        public string DIACHI { get; set; }
        public string EMAIL { get; set; }
        public string NIENKHOA { get; set; }
        public Nullable<bool> TRANGTHAI { get; set; }
        public string GHICHU { get; set; }
        public string NGANH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIEM> DIEMs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIEMTK_SV> DIEMTK_SV { get; set; }
        public virtual LOP LOP { get; set; }
        public virtual NGANH NGANH1 { get; set; }
        public virtual NIENKHOA NIENKHOA1 { get; set; }
    }
}

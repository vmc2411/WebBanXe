//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanXe.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            this.BLOGs = new HashSet<BLOG>();
            this.CONTACTs = new HashSet<CONTACT>();
            this.ORDERs = new HashSet<ORDER>();
            this.RENTs = new HashSet<RENT>();
        }
    
        public int IdUser { get; set; }
        public int IdRole { get; set; }
        public string FullName { get; set; }
        [Display(Name = "Địa chỉ Email")]
        public string Email { get; set; }
        [Display(Name = "Tên người dùng")]
        public string Username { get; set; }
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
        [Display(Name = "SĐT")]
        public string Phone { get; set; }
        [Display(Name = "Ngày tạo")]
        public Nullable<System.DateTime> DayCreate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BLOG> BLOGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTACT> CONTACTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER> ORDERs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RENT> RENTs { get; set; }
       
        public virtual USER_ROLE USER_ROLE { get; set; }
    }
}
